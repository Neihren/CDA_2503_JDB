using System.Collections;
using System.Globalization;
using System.Security;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Maecenas varius dui volutpat, facilisis eros rhoncus, ullamcorper lacus. Maue,at euismod tortor arcu vel dui.";
            Console.WriteLine(a);
            string saisie2 = "lavfal";
            bool verif = true;
            for (int i = 0; i < saisie2.Length; i++)
            {
                if (!saisie2[i].Equals(saisie2[saisie2.Length - 1 - i]))
                {
                    verif = false;
                }
            }
            Console.WriteLine(verif);
        }
    }
}
