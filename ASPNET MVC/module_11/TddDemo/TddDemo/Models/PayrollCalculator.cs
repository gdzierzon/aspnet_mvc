using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TddDemo.Models
{
    public class PayrollCalculator
    {
        public decimal CalulateGrossPay(double hours, decimal rate)
        {
            double overtime = 0;
            if (hours > 40)
            {
                overtime = hours - 40;
                hours = 40;
            }

            decimal grossPay = (decimal)hours * rate;
            decimal overtimePay = (decimal) (overtime * 1.5) * rate ;

            return grossPay + overtimePay;
        }
    }
}