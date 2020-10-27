using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizationMemberLibrary
{
    public class CommissionEmployee: Employee
    {
        public double CommissionRate { get; set; }


        public double CalculateCommission(double hoursWorked)
        {
            double total = (HourlyRate * hoursWorked) * CommissionRate;
            return total;
        }

        public override double PayAmount(double hoursWorked)
        {
            return (HourlyRate * hoursWorked) +
                CalculateCommission(hoursWorked);
        }
    }
}
