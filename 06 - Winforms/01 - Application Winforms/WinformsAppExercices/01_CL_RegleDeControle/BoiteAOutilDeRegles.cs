using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01_CL_RegleDeControle
{
    public static class BoiteAOutilDeRegles
    {
        public static bool IsStartingSpace(string _input)
        {
            return Regex.IsMatch(_input, @"^\s");
        }

        public static bool IsEndingSpace(string _input)
        {
            return Regex.IsMatch(_input, @"\s$");
        }
        
        public static bool IsEmpty(string _input)
        {
            return String.IsNullOrEmpty(_input);
        }

        public static bool IsMoreThan30(string _input)
        {
            return _input.Length > 31 ? true : false;
        }

        public static bool IsNameLessThan2(string _input)
        {
            return _input.Length < 2 ? true : false;
        }
        
        public static bool IsNameNotAlphabetic(string _name)
        {
            return !Regex.IsMatch(_name, @"^\p{L}+(?:[-' ]\p{L}+)*$");
            
        }

        public static bool IsDateFormatValid(string _date, out DateTime date)
        {
            if (!DateTime.TryParseExact(_date, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out date))
            {
                date = DateTime.MinValue;
                return false;
            }
            return true;
        }

        public static bool IsDateInPast(DateTime date)
        {
            return date < DateTime.Today ? true : false;
        }

        public static bool IsMoreThan20(string _input)
        {
            return _input.Length > 20 ? true : false;
        }




        public static bool IsMontantValid(string _montant, out decimal montant)
        {
            //_montant = _montant.Replace('.', ',');
            //if (!Regex.IsMatch(_montant, @"^\d+((\,|\.)\d+)?$"))
            //{
            //    montant = 0;
            //    return false;
            //}
            //return Decimal.TryParse(_montant, CultureInfo.GetCultureInfo("en-US"),out montant);
            
            return Decimal.TryParse(_montant, CultureInfo.CurrentCulture, out montant);
        }

        public static bool IsCodePostalValid(string _codePostal)
        {
            if (!Regex.IsMatch(_codePostal, @"^\d{5}$"))
            {
                return false;
            }
            return true;
        }

        
    }
}
