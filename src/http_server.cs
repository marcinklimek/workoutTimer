using System;
using System.IO;
using System.Text;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection.Metadata;

namespace WorkoutTimer
{


    public class Server : Qoollo.Net.Http.HttpServer
    {
        public WorkoutManager Manager;

        public Server(int port, WorkoutManager manager)
            : base(port)
        {
            Manager = manager;

            Get["/"] = GetRoot;
            Post["/api/v1/start/"] = HandleStart;
            Post["/api/v1/stop/"] = HandleStop;

            ServeStatic(new DirectoryInfo("html"), "static");
        }


        private string GetRoot(HttpListenerRequest arg)
        {
            string text = System.IO.File.ReadAllText(@"web\index.html");

            return text;
        }

        private string HandleStart(HttpListenerRequest arg)
        {
            try
            {
                var postData = GetRequestPostData(arg);
                
                WorkoutParameters? parameters = JsonSerializer.Deserialize<WorkoutParameters>(postData);
                
                if (parameters != null)
                {
                    parameters.workout *= 60; // in seconds
                    parameters.rest *= 60; // in seconds

                    Manager.SetupWorkout(parameters);
                    Manager.Start();
                }

            }
            catch (Exception e)
            {
                //do nothing
            }

            return GetRoot(arg);
        }

        private string HandleStop(HttpListenerRequest arg)
        {
            try
            {
                Manager.Stop();
            }
            catch (Exception e)
            {
                //do nothing
            }

            return GetRoot(arg);
        }

        public static string GetRequestPostData(HttpListenerRequest request)
        {
            if (!request.HasEntityBody)
            {
                return string.Empty;
            }

            using Stream body = request.InputStream;
            using var reader = new StreamReader(body, request.ContentEncoding);

            return reader.ReadToEnd();
        }

        public static void Start(WorkoutManager wm)
        {
            var httpThread = new Thread(() =>
            {
                var server = new Server(8080, wm);
                server.Run();
            });
            httpThread.Start();
        }
    }
}