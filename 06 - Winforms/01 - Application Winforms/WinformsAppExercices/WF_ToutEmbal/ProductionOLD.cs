using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ToutEmbal
{
    
    public class ProductionOLD
    {
        public delegate void DelegateProduction(ProductionOLD p);
        public event DelegateProduction ChangementProduction;
        private EnumProductionOLD etatProduction;
        private int cadenceProduction;
        private int objectifProduction;
        private int nbCaissesProduites;
        private int nbCaissesDefectueuses;
        private double tauxDefautHeure;
        private double tauxDefautCumule;
        private Random generateurAleatoire = new Random();
        private Queue<bool> historiqueDefaut = new Queue<bool>();

        public ProductionOLD(int cadenceProduction, int objectifProduction)
        {
            this.etatProduction = EnumProductionOLD.NonDemarre;
            this.cadenceProduction = cadenceProduction;
            this.objectifProduction = objectifProduction;
            this.nbCaissesProduites = 0;
            this.nbCaissesDefectueuses = 0;
            this.tauxDefautHeure = 0;
            this.tauxDefautCumule = 0;
        }

        public EnumProductionOLD EtatProduction { get => etatProduction; set => etatProduction = value; }
        public int CadenceProduction { get => cadenceProduction; set => cadenceProduction = value; }
        public int ObjectifProduction { get => objectifProduction; set => objectifProduction = value; }
        public int NbCaissesProduites { get => nbCaissesProduites; set => nbCaissesProduites = value; }
        public int NbCaissesDefectueuses { get => nbCaissesDefectueuses; set => nbCaissesDefectueuses = value; }
        public double TauxDefautHeure { get => tauxDefautHeure; set => tauxDefautHeure = value; }
        public double TauxDefautCumule { get => tauxDefautCumule; set => tauxDefautCumule = value; }

        public void Demarrer()
        {
            this.etatProduction = EnumProductionOLD.Demarre;
            this.nbCaissesProduites = 0;
            this.nbCaissesDefectueuses = 0;
            this.tauxDefautHeure = 0;
            this.tauxDefautCumule = 0;
            Thread threadProduction = new Thread(Produire);
            threadProduction.Start();
        }

        public void Arreter()
        {
            this.etatProduction = EnumProductionOLD.Suspendu;
        }

        public void Continuer()
        {
            this.etatProduction = EnumProductionOLD.Redemarre;
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
            while(this.etatProduction == EnumProductionOLD.Demarre || this.etatProduction == EnumProductionOLD.Redemarre)
            {
                ProduireCaisse();
                Thread.Sleep(36000/this.cadenceProduction);
                if (this.NbCaissesProduites >= this.objectifProduction)
                {
                    this.etatProduction = EnumProductionOLD.Termine;
                }
            }
            ChangementProduction?.Invoke(this);
        }
    }
}
