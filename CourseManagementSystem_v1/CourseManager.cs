using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class CourseManager
    {
         List<Course> courses = new List<Course>();

        public void CreateCourse(string title, string duration, decimal price)
        {
            var courseobj = new Course(courses.Count + 1), title, duration, price);
            courses.Add(courseobj);
        }


        public void ReadCourses()
        {
            if(courses.Count != 0)
            {
                foreach(var course in courses)
                {
                    Console.WriteLine($"ID:{course.CourseId},Title:{course.Title},Duration:{course.Duration},Price:{course.Price}");
                }
            }
            else
            {
                Console.WriteLine("Courses not found");
            }
        }

        public void UpdateCourses(int id,string title,string duration,decimal price)
        {
            var courseobj = courses.Find(c => c.CourseId == "@id");
            if(courseobj != null )
            {
                courses.Title = title;
                courses.Duration = duration;
                courses.Price = price;
                Console.WriteLine("Course Updated Successfully");
            }
            else
            {
                Console.WriteLine("Course not found");
            }
        }

        public void DeleteCourse(int id)
        {
            var courseobj1 = courses.Find(c => c.CourseId == "@id");
            if(courseobj1 != null)
            {
                courses.Remove(courseobj1);
                Console.WriteLine("Course Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Course Not found");
            }
        }


       

       

    }
}
