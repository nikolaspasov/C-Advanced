using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public int GetDays(string firstDate, string secondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);
            if (startDate > endDate)
            {
                return (int)(startDate - endDate).TotalDays;
            }
            else
            {
                return (int)(endDate - startDate).TotalDays;
            }
        }

        public string FirstDate
        {
            get
            {
                return firstDate;
            }
            set
            {
                value = firstDate;
            }
        }
        public string SecondDate
        {
            get
            {
                return secondDate;
            }
            set
            {
                value = secondDate;
            }
        }
    }
}
