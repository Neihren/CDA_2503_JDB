using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;


namespace CL_DemandeurEmploi
{
    public static class RegleValidation
    {
        public static bool IsStartingSpace(string input)
        {
            return input != null && Regex.IsMatch(input, @"^\s");
        }

        public static bool IsEndingSpace(string input)
        {
            return input != null && Regex.IsMatch(input, @"\s$");
        }

        public static bool IsEmpty(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        public static bool IsMoreThan20(string input)
        {
            return input?.Length > 20;
        }

        public static bool IsNameLessThan2(string input)
        {
            return input == null || input.Length < 2;
        }

        public static bool IsNameNotAlphabetic(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return true;
            // nom tous caractère alphabétiques avec prise en compte des - ' et espaces pour nom composé, particules
            return !Regex.IsMatch(name, @"^\p{L}+(?:[-' ]\p{L}+)*$");
        }

        public static bool IsDateFormatValid(string dateText, out DateOnly date)
        {
            // TryParseExact s'occupe de mettre 'date' à MinValue si ça échoue.
            return DateOnly.TryParseExact(dateText, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out date);
        }

        public static bool IsDateInFutur(DateOnly date)
        {
            // .Date assure qu'on ne compare pas les heures, juste les jours
            return date > DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
