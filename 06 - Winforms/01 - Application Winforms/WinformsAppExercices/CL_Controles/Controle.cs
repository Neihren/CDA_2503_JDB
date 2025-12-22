using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace CL_Controles
{
    public class Controle
    {
        public static bool IsNomValid(string _nom, out string? nom)
        {
            if (string.IsNullOrWhiteSpace(_nom) || !Regex.IsMatch(_nom, @"^[a-zA-Z]+$") || _nom.Length > 30)
            {
                nom = null;
                return false;
            }
            nom = _nom;
            return true;
        }

        public static bool IsMontantValid(string _montant, out decimal? montant)
        {
            if (!Regex.IsMatch(_montant, @"^\d+(\.\d+)?$"))
            {
                montant = null;
                return false;
            }
            montant = Convert.ToDecimal(_montant);
            return true;
        }

        public static bool IsCodePostalValid(string _codePostal, out string? codePostal)
        {
            if (!Regex.IsMatch(_codePostal, @"^\d{5}$"))
            {
                codePostal = null;
                return false;
            }
            codePostal = _codePostal;
            return true;
        }

        public static bool IsDateValid(string _date, out DateTime? date)
        {
            if (DateTime.TryParseExact(_date, "dd/MM/yyyy", out date))
            {
                date = DateTime.Parse(_date);
                return true;
            }
            date = null;
            return false;
        }
    }
}
