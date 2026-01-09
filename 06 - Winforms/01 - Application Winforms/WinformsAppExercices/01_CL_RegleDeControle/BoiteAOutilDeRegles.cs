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
            return _input.Length > 31;
        }

        public static bool IsNameLessThan2(string _input)
        {
            return _input.Length < 2;
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

        public static (bool, DateTime) IsDateFormatValid(string _date)
        {
            bool ok = BoiteAOutilDeRegles.IsDateFormatValid(_date,out DateTime date);
            return (ok, date);
        }

        public static bool IsDateInPast(DateTime date)
        {
            return date < DateTime.Today;
        }

        public static bool IsMoreThan20(string _input)
        {
            return _input.Length > 20;
        }

        public static bool IsAmountNegative(string _amount)
        {
            return _amount.Contains('-');
        }

        public static bool IsAmountValid(string _amount, out decimal amount)
        {
            //_amount = _amount.Replace('.', ',');
            //if (!Regex.IsMatch(_amount, @"^\d+((\,|\.)\d+)?$"))
            //{
            //    amount = 0;
            //    return false;
            //}
            //return Decimal.TryParse(_amount, CultureInfo.GetCultureInfo("en-US"),out amount);

            return Decimal.TryParse(_amount, CultureInfo.CurrentCulture, out amount);
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
