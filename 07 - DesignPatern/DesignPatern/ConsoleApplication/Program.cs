using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibIteratorPattern;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            ListeDeJoueurs p = new ListeDeJoueurs();//modifier en listeDeJoueurs
           

            p.AjouterJoueur("Beltran", "Bernard");
            p.AjouterJoueur("Boni", "Brice");
            p.AjouterJoueur("Peter", "Theo");
            p.AjouterJoueur("Edebau", "Marjorie");
            p.AjouterJoueur("Zidane", "Zinedine");
            p.AjouterJoueur("Platini","Michel");
            p.SupprimerJoueur("Zidane", "Zinedine");
            //p.SupprimerJoueur("Boni", "Brice");
            

            for (int i = 0; i < p.Count; i++)
            {
                Joueur j = p.GetJoueurALaPosition(i);
                Console.WriteLine(j.Nom + " , " + j.Prenom);
            }

            Console.WriteLine();
          
            ////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < p.Count;i++ )
            {
                Joueur j = p[i];
                Console.WriteLine(j.Nom + " , " + j.Prenom);
            }

            Console.WriteLine();
            
            ////////////////////////////////////////////////////////////////////////////////////////

            ConcreteListeDeJoueursEnumerator c = (ConcreteListeDeJoueursEnumerator)p.GetEnumerator();

            while (c.MoveNext()) 
            {
                Joueur j = (Joueur)c.Current;
                Console.WriteLine(j.Nom + " , " + j.Prenom);
            }

            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////////////

            foreach (Joueur j in p)
            {
                Console.WriteLine(j.Nom + " , " + j.Prenom);
            }

            Console.ReadLine();
        }
    }
}
