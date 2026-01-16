namespace WF_Defilement
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
            Color c = Color.White;
            Form_Defilement f = new Form_Defilement(c);
   

            Application.Run(f);
            Color cr = f.CouleurConfigure;
        }
    }
}