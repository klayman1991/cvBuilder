using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models
{
    public class Work
    {
        public int WorkID { get; set; }

        public string WorkName { get; set; }

        public string WorkPosition { get; set; }

        public DateTime WorkStartDate { get; set; }

        public DateTime WorkEndDate { get; set; }

        public ICollection<WorkDescription> WorkDescriptions { get; set; }

        

    }

    
}
