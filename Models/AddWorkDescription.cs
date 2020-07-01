using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models
{
    public class AddWorkDescription
    {
    
        private List<WorkDescription> workDescriptions = new List<WorkDescription>();
       
        public virtual void AddDescription(Work work, string workDesc)
        {


            WorkDescription line = workDescriptions
                .Where(p => p.WorkDescriptionID == work.WorkID)
                .FirstOrDefault();
            if (line == null)
            {
                workDescriptions.Add(new WorkDescription
                {
                    Work = work,
                    WorkDescriptionText = workDesc
                });
            }
        }
        public virtual void RemoveDescription(WorkDescription work) => workDescriptions.RemoveAll(l => l.WorkDescriptionID == work.WorkDescriptionID);

        public virtual IEnumerable<WorkDescription> Descriptions => workDescriptions;
    }


    public class WorkDescription
    {
        public int WorkDescriptionID { get; set; }

        public Work Work { get; set; }

        public string WorkDescriptionText { get; set; }
    }
}
