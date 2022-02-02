using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Programs
{
    class Student1
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
            Console.WriteLine("---------------------------------------------------");
        }
        public void ShowStudentData()
        {
            Console.WriteLine("Student ID: {0}", studentid);
            Console.WriteLine("Student Name: {0}", studentname);
            Console.WriteLine("Student Age: {0}", studentage);
            Console.WriteLine("---------------------------------------------------");
        }
        class MultipleData
        {
            static void Main(string[] args)
            {
                Student1[] student = new Student1[100];
                Console.Write("No.of students data , you want to enter:");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter Student {0} Data:", i + 1);
                    Student1 student1 = new Student1();
                    student1.GetStudentData();
                    student[i] = student1;
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Student {0} Data:", i+1);
                    student[i].ShowStudentData();
                }
            }
        }
    }
}
