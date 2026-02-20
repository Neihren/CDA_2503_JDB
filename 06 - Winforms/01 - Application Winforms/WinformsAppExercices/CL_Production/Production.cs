using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Production
{
    
    public class Production
    {
        public delegate void DelegateProduction(Production p);
        public event DelegateProduction ChangementProduction;
        private EnumProduction etatProduction;
        private int cadenceProduction;
        private int objectifProduction;
        private int nbCaissesProduites;
        private int nbCaissesDefectueuses;
        private double tauxDefautHeure;
        private double tauxDefautCumule;
        private Random generateurAleatoire = new Random();
        private Queue<bool> historiqueDefaut = new Queue<bool>();

        public Production(int cadenceProduction, int objectifProduction)
        {
            this.etatProduction = EnumProduction.NonDemarre;
            this.cadenceProduction = cadenceProduction;
            this.objectifProduction = objectifProduction;
            this.nbCaissesProduites = 0;
            this.nbCaissesDefectueuses = 0;
            this.tauxDefautHeure = 0;
            this.tauxDefautCumule = 0;
        }

        public EnumProduction EtatProduction { get => etatProduction; set => etatProduction = value; }
        public int CadenceProduction { get => cadenceProduction; set => cadenceProduction = value; }
        public int ObjectifProduction { get => objectifProduction; set => objectifProduction = value; }
        public int NbCaissesProduites { get => nbCaissesProduites; set => nbCaissesProduites = value; }
        public int NbCaissesDefectueuses { get => nbCaissesDefectueuses; set => nbCaissesDefectueuses = value; }
        public double TauxDefautHeure { get => tauxDefautHeure; set => tauxDefautHeure = value; }
        public double TauxDefautCumule { get => tauxDefautCumule; set => tauxDefautCumule = value; }

        public void Demarrer()
        {
            this.etatProduction = EnumProduction.Demarre;
            this.nbCaissesProduites = 0;
            this.nbCaissesDefectueuses = 0;
            this.tauxDefautHeure = 0;
            this.tauxDefautCumule = 0;
            Thread threadProduction = new Thread(Produire);
            threadProduction.Start();
        }

        public void Arreter()
        {
            this.etatProduction = EnumProduction.Suspendu;
        }

        public void Continuer()
        {
            this.etatProduction = EnumProduction.Redemarre;
            Thread threadProduction = new Thread(Produire);
            threadProduction.Start();
        }

        public void ProduireCaisse()
        {
            int defautDernierePeriode = 0;
            if(this.generateurAleatoire.NextDouble() <= 0.05)
            {
                this.nbCaissesDefectueuses++;
                this.historiqueDefaut.Enqueue(true);
            }
            else
            {
                this.historiqueDefaut.Enqueue(false);
            }
            if (this.historiqueDefaut.Count > this.cadenceProduction)
            {
                this.historiqueDefaut.Dequeue();
            }
            foreach (bool defaut in historiqueDefaut)
            {
                if (defaut)
                {
                    defautDernierePeriode++;
                }
            }
            this.nbCaissesProduites++;
            this.tauxDefautHeure = defautDernierePeriode * 100.0 / this.historiqueDefaut.Count;
            this.tauxDefautCumule = this.nbCaissesDefectueuses * 100.0 / this.nbCaissesProduites;
            ChangementProduction?.Invoke(this);
        }

        private void Produire()
        {
            while(this.etatProduction == EnumProduction.Demarre || this.etatProduction == EnumProduction.Redemarre)
            {
                ProduireCaisse();
                Thread.Sleep(36000/this.cadenceProduction);
                if (this.NbCaissesProduites >= this.objectifProduction)
                {
                    this.etatProduction = EnumProduction.Termine;
                }
            }
            ChangementProduction?.Invoke(this);
            /*if (ChangementProduction != null)
            {
                ChangementProduction(this);
            }*/
        }
    }
}
