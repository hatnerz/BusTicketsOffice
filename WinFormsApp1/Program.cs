namespace WinFormsApp1
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static ApplicationContext Context { get; set; }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Context = new ApplicationContext(new RouteChose());
            Application.Run(Context);
        }
    }
}