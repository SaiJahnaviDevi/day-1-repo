using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Programs
{
    class Student
    {
        int studentid;
        string studentname;
        int studentage;
        public void GetStudentData()
        {
            Console.Write("Enter Student ID:");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name:");
            studentname = Console.ReadLine();
            Console.Write("Enter Student Age:");
            studentage = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowStudentData()
        {
            Console.WriteLine("Student Data:");
            Console.WriteLine("Student ID: {0}", studentid);
            Console.WriteLine("Student Name: {0}", studentname);
            Console.WriteLine("Student Age: {0}", studentage);
        }
    }
    class StudentDetails
    {
        static void Main3(string[] args)
        {
            Student student = new Student();
            student.GetStudentData();
            student.ShowStudentData();
        }
    }
}
