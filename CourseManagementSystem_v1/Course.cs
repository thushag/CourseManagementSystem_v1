using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {
        private string CourseId;
        private string Title;
        private string Duration;
        private decimal Price;

        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
        }
        public void set 
      
      //  public string CourseId {
      //  get { return courseId; }
      //  }
       // public string Title { get { return title; } }

        public override string ToString()
        {
            return $"ID:{CourseId},Title:{Title},Duration:{Duration},Price:{Price}";
        }

    }
}
