namespace ClassLibrary_421
{
    public class De
    {
        private int valeurEntre1Et6;
        private bool deConserve;

        public De() 
        {
            valeurEntre1Et6 = 0;
            deConserve = false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} [valeurEntre1Et6 : {this.valeurEntre1Et6}, deConserve : {this.deConserve}]";
        }

        public void ConserverDe()
        {
            this.deConserve = true;
        }

        public void LancerDe()
        {
            if (this.deConserve == false)
            {
                this.valeurEntre1Et6 = Alea.Instance().Nouveau(1, 6);
            }
        }
    }
}
