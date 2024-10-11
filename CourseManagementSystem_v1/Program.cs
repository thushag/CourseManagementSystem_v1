using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager manager = new CourseManager();
           bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Course Management System");
                Console.WriteLine("1.Add a Course");
                Console.WriteLine("2.View All Courses");
                Console.WriteLine("3.Update a Course");
                Console.WriteLine("4.Delete a Course");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Choose an Option");
                var option = Console.ReadLine();
                while (option != null)
                {
                    switch(option)
                    {
                        //case "1":
                        //    Console.WriteLine("Enter Course Id");
                        //    int CourseId = Console.ReadLine();

                        //    Console.WriteLine("Enter Course Title");
                        //    string Title = Console.ReadLine();

                    }
                }
            }
            
        }
    }
}
