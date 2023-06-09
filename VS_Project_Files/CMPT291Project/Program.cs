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
            bool testing = false;

            if (testing)
            {
                DB_Helper dbHelper = new DB_Helper();
                dbHelper.test();

                return;
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Enable colors, fonts, and other visual elements from OS
            Application.EnableVisualStyles();
            // False means beter text rendering
            Application.SetCompatibleTextRenderingDefault(false);

            // Login code added
            MainForm mainFormInstance = new MainForm();
            LoginForm loginFormInstance = new LoginForm(mainFormInstance);

            Application.Run(loginFormInstance);
        }
    }
}