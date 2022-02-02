using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Programs
{
    class Employee
    {
        int empid;
        string empname;
        int empage;
        string empgender;
        double empsalary;
        long empphn;
        public void GetEmployeeData()
        {
            Console.Write("Enter Employee ID:");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            empname = Console.ReadLine();
            Console.Write("Enter Employee Age:");
            empage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Gender:");
            empgender = Console.ReadLine();
            Console.Write("Enter Employee Salary:");
            empsalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Employee Phone Number:");
            empphn = Convert.ToInt64(Console.ReadLine());
        }
        public void ShowEmployeeData()
        {
            Console.WriteLine(" Employee Data:");
            Console.WriteLine("Employee ID: {0}", empid);
            Console.WriteLine("Employee Name: {0}", empname);
            Console.WriteLine("Employee Age: {0}", empage);
            Console.WriteLine("Employee Gender: {0}", empgender);
            Console.WriteLine("Employee Salary: {0}", empsalary);
            Console.WriteLine("Employee Phone Number: {0}", empphn);
        }
    }
    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetEmployeeData();
            employee.ShowEmployeeData();
        }
    }

}

