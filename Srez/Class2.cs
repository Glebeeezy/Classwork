using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srez
{
    internal static class DateTimeExtension
    {
        private const int CreationOfTheWorld = 5501;



        public static string YearFromCrationOfTheWorld()
        {
            DateTime dateTime = new DateTime();

            string mounth = dateTime.ToString("MMMM");
           
            int year = dateTime.Year + CreationOfTheWorld;

            string dateTimeStr = $"{dateTime.Day}, {mounth}, {year}";

            return dateTimeStr;
        }
    }
}
