namespace WorkoutTimer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WorkoutManager manager = new WorkoutManager();

            Server.Start(manager);


            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen(manager));
        }
    }
}