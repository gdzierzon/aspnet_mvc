using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class DateManager
    {
        private DateTime theDate;

        public DateManager(DateTime date)
        {
            theDate = date;
        }

        public DateTime GetOneWeekFromTheDate()
        {
            DateTime oneWeekAway = theDate.AddDays(7);
            return oneWeekAway;
        }

        public static DateTime GetOneWeekFromToday()
        {
            DateTime oneWeekAway = DateTime.Now;
            oneWeekAway = oneWeekAway.AddDays(7);
            return oneWeekAway;
        }

    }
}
