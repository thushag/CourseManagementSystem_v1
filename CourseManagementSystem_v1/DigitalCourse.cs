using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class DigitalCourse : Course
    {
        public string CourseLink;
        public string FileSize;


        public DigitalCourse(string courseId, string title, string duration, decimal price, string courseLink, string fileSize) : base(courseId, title, duration, price)
        {
            CourseLink = courseLink;
            FileSize = fileSize;

        }

        //public override string DisplayCourseInfo()
        //{
        //    return base.DisplayCourseInfo()+ "$,CourseLink:{courseLink},FileSize:{fileSize}";
        //}

    }
}
