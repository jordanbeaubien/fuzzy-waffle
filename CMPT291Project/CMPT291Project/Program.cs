namespace CMPT291Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());


            // Login code added
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);

            Form2 formMain = new Form2();
            Form1 formLogin = new Form1(formMain);

            Application.Run(formLogin);
        }
    }
}