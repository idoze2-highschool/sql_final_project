using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static class Methods
    {
        /// <summary>
        /// Returns Day by name from Indexing Number
        /// </summary>
        /// <param name="day">Index of the Day in the week</param>
        /// <returns></returns>
        public static string GetDayName(int day)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (day > 7)
                return days[6];
            return days[day - 1];
        }
        /// <summary>
        /// Formats a num to an Indexing Format
        /// For examle, 1 => 1st, 10 => 10th
        /// </summary>
        /// <param name="num"> </param>
        /// <returns></returns>
        public static string ToIndexingNumber(int num)
        {
            switch (num)
            {
                default:
                    return num.ToString() + "th";
                case 1:
                    return "1st";
                case 2:
                    return "2nd";
                case 3:
                    return "3rd";
            }
        }
        /// <summary>
        /// Returns Whether or not str consists only of A-Z,a-z Characters.
        /// </summary>
        /// <param name="str">Tested String</param>
        public static bool IsValidString(string str)
        {
                return System.Text.RegularExpressions.Regex.IsMatch(str, @"^[a-zA-Z]+$");
        }
        /// <summary>
        /// Returns Whether or not str is a string representation of a 9 digit number.
        /// </summary>
        /// <param name="str"></param>
        public static bool IsValidSocialID(string str)
        {
                return (System.Text.RegularExpressions.Regex.IsMatch(str, @"^[0-9]{9}$"));
        }
    }
}
