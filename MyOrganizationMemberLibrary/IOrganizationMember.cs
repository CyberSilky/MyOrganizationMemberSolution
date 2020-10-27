using System;
using System.Collections.Generic;
using System.Text;


//This is an interface
namespace MyOrganizationMemberLibrary
{
    interface IOrganizationMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Employee { get; set; }
        double HourlyRate { get; set; }

        string PrintEmployeeInformation();
        double PayAmount(double hoursWorked);

    }
}
