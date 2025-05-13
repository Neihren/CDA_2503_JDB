using System.Collections.Generic;
using System;

namespace Voitures
{
    public class Voiture : IComparable<Voiture>
    {
        private int numeroSerie;
        private string marque;
        private string modele;
        private DateTime dateMiseEnCirculation;

        public Voiture(int numeroSerie, string marque, string modele, DateTime dateMiseEnCirculation)
        {
            this.numeroSerie = numeroSerie;
            this.marque = marque;
            this.modele = modele;
            this.DateMiseEnCirculation = dateMiseEnCirculation;
        }

        public int NumeroSerie { get => numeroSerie; set => numeroSerie = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Modele { get => modele; set => modele = value; }
        public DateTime DateMiseEnCirculation { get => dateMiseEnCirculation; set => dateMiseEnCirculation = value; }

        public override string ToString()
        {
            return ($"Numéro de Série : {this.numeroSerie}, Marque : {this.marque}, Modèle : {this.modele}, Date de mise en circulation : {this.dateMiseEnCirculation.ToString("dd/MM/yyyy")}");
        }

        public int CompareTo(Voiture compareVoiture)
        {
            if (compareVoiture == null)
            {
                return 1;
            }
            else
            {
                return this.numeroSerie.CompareTo(compareVoiture.numeroSerie);
            }
        }
    }

    class CompareByNumeroSerie : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            if (x.NumeroSerie > y.NumeroSerie)
                return 1;
            if (x.NumeroSerie < y.NumeroSerie)
                return -1;
            else
                return 0;
        }
    }

    public class CompareByModele : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.Modele.CompareTo(y.Modele);
        }
    }
    public class CompareByMarque : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.Marque.CompareTo(y.Marque);
        }
    }

    public class CompareByDate : IComparer<Voiture>
    {
        public int Compare(Voiture x, Voiture y)
        {
            return x.DateMiseEnCirculation.CompareTo(y.DateMiseEnCirculation);
        }
    }
}
