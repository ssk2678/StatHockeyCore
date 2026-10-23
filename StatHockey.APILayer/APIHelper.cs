using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.APILayer
{
    static class APIHelper
    {
        public static string GetCurrentSeason()
        {
            string currentSeason;

            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            if (currentMonth <= 9)
            {
                currentSeason = (currentYear - 1).ToString() + currentYear.ToString();
            }
            else
            {
                currentSeason = currentYear.ToString() + (currentYear + 1).ToString();
            }

            return currentSeason;
        }
    }
}
