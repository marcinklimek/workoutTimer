using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WorkoutTimer
{
    class HttpServer
    {
        private Thread httpThread;

        public static HttpListener listener;
        public static string url = "http://*:8000/";
        public static int pageViews = 0;
        public static int requestCount = 0;

        public static WorkoutManager Manager;

        public static string pageData =
            "<!DOCTYPE>" +
            "<html>" +
            "  <head>" +
            "    <title>HttpListener Example</title>" +
            "  </head>" +
            "  <body>" +
            "    <p>Page Views: {0}</p>" +
            "    <form method=\"post\" action=\"start\">" +
            "        <label for=\"workout\" class=\"formbuilder-number-label\">Workout (min)</label>" +
            "        <input type=\"number\" class=\"form-control\" name=\"workout\" access=\"false\" min=\"1\" max=\"69\" step=\"1\" id=\"workout\">" +
            "        <label for=\"rest\" class=\"formbuilder-number-label\">Rest (min)</label>" +
            "        <input type=\"number\" class=\"form-control\" name=\"rest\" access=\"false\" min=\"1\" max=\"69\" step=\"1\" id=\"rest\">" +
            "        <label for=\"rounds\" class=\"formbuilder-number-label\">Rounds</label>" +
            "        <input type=\"number\" class=\"form-control\" name=\"rounds\" access=\"false\" min=\"1\" max=\"69\" step=\"1\" id=\"rounds\">" +
            "        <input type=\"submit\" value=\"start\" {1}>" +
            "    </form>" +
            "  </body>" +
            "</html>";

        public static string GetRequestPostData(HttpListenerRequest request)
        {
            if (!request.HasEntityBody)
            {
                return null;
            }
            using (System.IO.Stream body = request.InputStream) // here we have data
            {
                using (var reader = new System.IO.StreamReader(body, request.ContentEncoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;

            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (runServer)
            {
                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await listener.GetContextAsync();

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                //// Print out some info about the request
                //Console.WriteLine("Request #: {0}", ++requestCount);
                //Console.WriteLine(req.Url.ToString());
                //Console.WriteLine(req.HttpMethod);
                //Console.WriteLine(req.UserHostName);
                //Console.WriteLine(req.UserAgent);
                //Console.WriteLine();

                // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/start"))
                {
                    var postData = GetRequestPostData(req);

                    var list = postData.Split("&");

                    int workTime = 1;
                    int restTime = 1;
                    int numRounds = 1;

                    foreach (var item in list)
                    {
                        var key_value = item.Split("=");


                        switch(key_value[0])
                        {
                            case "workout": workTime=int.Parse(key_value[1]); break;
                            case "rest": restTime = int.Parse(key_value[1]); break;
                            case "rounds": numRounds = int.Parse(key_value[1]); break;
                        };
                    }

                    Manager.SetupWorkout(workTime*60, restTime*60, numRounds);
                    Manager.Start();
                }
                if ((req.HttpMethod == "POST") && (req.Url.AbsolutePath == "/stop"))
                {
                    Manager.SetupWorkout(60, 60, 3);
                    Manager.Start();
                }


                // Make sure we don't increment the page views counter if `favicon.ico` is requested
                if (req.Url.AbsolutePath != "/favicon.ico")
                    pageViews += 1;

                // Write the response info
                string disableSubmit = !runServer ? "disabled" : "";
                byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, pageViews, disableSubmit));
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }


        public void Start(WorkoutManager wm)
        {
            var httpThread = new Thread( () => 
            {            
                listener = new HttpListener();
                Manager = wm;
                listener.Prefixes.Add(url);
                listener.Start();
                Console.WriteLine("Listening for connections on {0}", url);

                // Handle requests
                Task listenTask = HandleIncomingConnections();
                listenTask.GetAwaiter().GetResult();

                // Close the listener
                listener.Close();
            });
            httpThread.Start();
        }

    }
}