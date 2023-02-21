namespace SolutionParking
{
    internal static class Program
    {
        public static string DbName = "dbSolutionParking.db";
        public static string DbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", DbName);//= FileAccessHelper.GetLocalFilePath(DbName);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
        public static void Main(string dbName, string dbPath)
        {
            
            Program.DbName = dbName;
            Program.DbPath = dbPath;

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}