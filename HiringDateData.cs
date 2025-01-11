using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment_oop_3
{
    #region 2.Develop a Class to represent the Hiring Date Data:•	Consisting of fields to hold the day, month and Years.
    internal class HiringDateData
    {
        private int day;
        private int month;
        private int year;



        public int Day
        {
            get { return day; }
            set { day = (value <= 31 && value > 0) ? value : 0; }
        }

        public int Month
        {
            get { return month; }
            set { month = (value <= 12 && value > 0) ? value : 0; }
        }
        public int Year
        {
            get { return year; }
            set { year = (value >= 1900 && value <= 2025) ? value : 0; }
        }
        public HiringDateData(int Day, int Month, int Year)
        {
            day = Day;
            month = Month;
            year = Year;
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
    }
    #endregion

}
