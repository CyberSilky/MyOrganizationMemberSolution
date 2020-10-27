using System;

namespace MyOrganizationMemberLibrary
{
    public class Employee: IOrganizationMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }

        private double rate;

        public double HourlyRate
        {
            get { return rate; }
            set
            {
                if (value > 0.0)
                {
                    rate = value;
                }
                else
                    throw new ApplicationException("The rate must be greater then $0.00");
            }
        }

        string IOrganizationMember.Employee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual double PayAmount(double hoursWorked)
        {
            return hoursWorked * rate;
        }

        public string PrintEmployeeInformation()
        {
            return $"Name is {FirstName} {LastName} and Employee Id is: {EmployeeId}";
        }
    }
}
