﻿using Voit;

namespace Voit_Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture("Cupra", 120, 17, true);
            Console.WriteLine(voiture.ToString());
            voiture.Demarrer();
            Console.WriteLine(voiture.ToString());
            voiture.Avancer();
            Console.WriteLine(voiture.ToString());
            voiture.Arreter();
            Console.WriteLine(voiture.ToString());

        }
    }
}
