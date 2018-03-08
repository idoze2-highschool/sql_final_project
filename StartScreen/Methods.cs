using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GystClient
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
    }
}
