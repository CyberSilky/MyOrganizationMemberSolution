using System;
using System.Collections.Generic;
using System.Text;

namespace MyOrganizationMemberLibrary
{
    class SampleinterfaceImplementation : IOrganizationMember
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Employee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double HourlyRate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double PayAmount(double hoursWorked)
        {
            throw new NotImplementedException();
        }

        public string PrintEmployeeInformation()
        {
            throw new NotImplementedException();
        }
    }
}
