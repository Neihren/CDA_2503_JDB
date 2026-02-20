using CL_DemandeurEmploi;

namespace WF_TrouveEmploi
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
            DemandeurEmploi demandeur = new DemandeurEmploi("Jessy", new DateOnly(2026, 02, 20), EnumNiveauFormation.BacPlus2);
            Form_TrouveEmploi f = new Form_TrouveEmploi(demandeur);
            Application.Run(f);
            DemandeurEmploi result = f.DemandeurModifie;
            

        }
    }
}