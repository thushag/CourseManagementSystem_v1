using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {
        public string CourseId;
        public string Title;
        public string Duration;
        public decimal Price;

        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
        }

        //public void Set CourseId()
        //{
        //    this.courseId = CourseId;
        //}

        //public int GetCourseId()
        //{
        //    return CourseId;
        //}
      
        public override string ToString()
        {
            return $"ID:{CourseId},Title:{Title},Duration:{Duration},Price:{Price}";
        }

        //public virtual string DisplayCourseInfo()
        //{
        //    return $"ID:{CourseId},Title:{Title},Duration:{Duration},Price:{Price}";
        //}

    }
}
