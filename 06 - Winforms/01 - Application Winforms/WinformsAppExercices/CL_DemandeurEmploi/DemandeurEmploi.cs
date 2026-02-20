namespace CL_DemandeurEmploi
{
    public class DemandeurEmploi
    {
        private string nom;
        private DateOnly dateInsciption;
        private EnumNiveauFormation niveauFormationMax;

        public DemandeurEmploi(string nom, DateOnly dateInsciption, EnumNiveauFormation niveauFormationMax)
        {
            this.nom = nom;
            this.dateInsciption = dateInsciption;
            this.niveauFormationMax = niveauFormationMax;
        }

        public string Nom { get => nom; set => nom = value; }
        public DateOnly DateInsciption { get => dateInsciption; set => dateInsciption = value; }
        public EnumNiveauFormation NiveauFormationMax { get => niveauFormationMax; set => niveauFormationMax = value; }
    }
}
