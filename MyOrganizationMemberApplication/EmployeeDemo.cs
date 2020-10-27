using System;
using static System.Console;
using MyOrganizationMemberLibrary;

//Name: James Shoemaker
//Date: 04/19/2020
//Program Description: Module 5 part 2 
//Continued in Module 6

namespace MyOrganizationMemberApplication
{
    class EmployeeDemo
    {
        static void Main(string[] args)
        {
            double hours;
            Employee employee1 = new Employee();
            CommissionEmployee cEmployee1 = new CommissionEmployee();


            //Employee Type Object Demo
            WriteLine("Employee type example........");
            WriteLine();
            Write("Please enter your first name: ");
            employee1.FirstName = ReadLine();

            Write("Please enter your last name: ");
            employee1.LastName = ReadLine();

            Write("Please enter your employee Id: ");
            employee1.EmployeeId = ReadLine();

            Write("Please enter your hourly rate: ");
            employee1.HourlyRate = double.Parse(ReadLine());

            Write("Please enter the hours you have worked: ");
            hours = double.Parse(ReadLine());

            WriteLine("Please review your information..... ");
            WriteLine(employee1.PrintEmployeeInformation());

            WriteLine($"Your pay will be: {employee1.PayAmount(hours).ToString("C")}");

            //Commission Employeee Type Object Demo
            WriteLine();
            WriteLine("Commission Employee type example........");
            WriteLine();
            Write("Please enter your first name: ");
            cEmployee1.FirstName = ReadLine();

            Write("Please enter your last name: ");
            cEmployee1.LastName = ReadLine();

            Write("Please enter your employee Id: ");
            cEmployee1.EmployeeId = ReadLine();

            Write("Please enter your hourly rate: ");
            cEmployee1.HourlyRate = double.Parse(ReadLine());

            Write("Please enter the hours you have worked: ");
            hours = double.Parse(ReadLine());

            Write("Please enter your commission rate: ");
            cEmployee1.CommissionRate = double.Parse(ReadLine());

            WriteLine("Please review your information..... ");
            WriteLine(cEmployee1.PrintEmployeeInformation());

            WriteLine($"Your pay will be: {cEmployee1.PayAmount(hours).ToString("C")}");


        }
    }


}
