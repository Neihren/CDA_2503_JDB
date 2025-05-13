using Voitures;
namespace AppClient_Kiloutou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Voiture> vehicules = new List<Voiture>();
            //vehicules.Add(new Voiture(2098, "Peugeot", "307", DateTime.Parse("24-07-1987")));
            //vehicules.Add(new Voiture(1987, "Renault", "Espace", DateTime.Parse("21-11-1962")));
            //vehicules.Add(new Voiture(1203, "Lancia", "Dedra", DateTime.Parse("08-05-1960")));
            //vehicules.Add(new Voiture(1500, "Bmw", "324d", DateTime.Parse("30-03-1981")));
            //vehicules.Add(new Voiture(2500, "Peugeot", "406", DateTime.Parse("12-09-1979")));
            //vehicules.Add(new Voiture(3049, "Ford", "Mondeo", DateTime.Parse("25-05-1990")));

            List<Voiture> vehicules = new List<Voiture>
            {
                new Voiture(2098, "Peugeot", "307", DateTime.Parse("1987-07-24")),
                new Voiture(1987, "Renault", "Espace", DateTime.Parse("21-11-1962")),
                new Voiture(1203, "Lancia", "Dedra", DateTime.Parse("08-05-1960")),
                new Voiture(1500, "Bmw", "324d", DateTime.Parse("30-03-1981")),
                new Voiture(2500, "Peugeot", "406", DateTime.Parse("12-09-1979")),
                new Voiture(3049, "Ford", "Mondeo", DateTime.Parse("25-05-1990"))
            };
            Console.WriteLine("Avant le tri :");
            AfficherListe(vehicules);
            Console.WriteLine("\nTri par numéro de série :");
            //vehicules.Sort((x, y) => x.NumeroSerie.CompareTo(y.NumeroSerie));
            vehicules.Sort();
            AfficherListe(vehicules);

            Console.WriteLine("\nTri par modèle :");
            //vehicules.Sort(delegate (Voiture x, Voiture y)
            //{
            //    if (x.Modele == null && y.Modele == null) return 0;
            //    else if (x.Modele == null) return -1;
            //    else if (y.Modele == null) return 1;
            //    else return x.Modele.CompareTo(y.Modele);
            //});
            vehicules.Sort((x, y) => x.Modele.CompareTo(y.Modele));
            AfficherListe(vehicules);

            Console.WriteLine("\nTri par marque :");
            vehicules.Sort(delegate (Voiture x, Voiture y)
            {
                if (x.Marque == null && y.Marque == null) return 0;
                else if (x.Marque == null) return -1;
                else if (y.Marque == null) return 1;
                else return x.Marque.CompareTo(y.Marque);
            });
            
            //vehicules.Sort((x, y) => x.Marque.CompareTo(y.Marque));
            AfficherListe(vehicules);

            Console.WriteLine("\nTri par date :");
            //vehicules.Sort(delegate (Voiture x, Voiture y)
            //{
            //    return x.DateMiseEnCirculation.CompareTo(y.DateMiseEnCirculation);
            //});

            //vehicules.Sort((x, y) => x.DateMiseEnCirculation.CompareTo(y.DateMiseEnCirculation));
            vehicules.Sort(new CompareByDate());
            AfficherListe(vehicules);
            
            Console.WriteLine("Vehicule recherché :");
            Voiture D = vehicules.Find(vehicule => vehicule.Modele.Equals("406"));
            Console.WriteLine(D.ToString());

            AfficherListe(vehicules.FindAll(vehicule => vehicule.DateMiseEnCirculation >= new DateTime(1978, 12, 31) && vehicule.Marque.Equals("Peugeot")));
            //AfficherListe(vehicules.FindAll(vehicule => vehicule.DateMiseEnCirculation.Year < 1979));
        }

        public static void AfficherListe(List<Voiture> vehicules)
        {
            foreach (Voiture item in vehicules)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
