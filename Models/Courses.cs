using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models

{
    public class Courses
    {
        public int CoursesID { get; set; }

        public string CoursesName { get; set; }
        public string CoursesDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

    }
}
