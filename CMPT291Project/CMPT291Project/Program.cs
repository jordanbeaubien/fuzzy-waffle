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

            // Enable colors, fonts, and other visual elements from OS
            Application.EnableVisualStyles();
            // False means beter text rendering
            Application.SetCompatibleTextRenderingDefault(false);

            // Login code added
            Form2 formMain = new Form2();
            Form1 formLogin = new Form1(formMain);

            Application.Run(formLogin);
        }
    }
}