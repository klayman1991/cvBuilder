using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models
{
    public class UserDetails
    {
        public UserDetails() : this(0)
        {

        }

        public UserDetails(int userID)
        {
            UserDetailsID = userID;
           // EducationTypesList = new List<Courses>();
        }


        public int UserDetailsID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public DateTime Dateofbirth { get; set; }

        public List<Courses> EducationTypesList { get; set; }

        public List<About> About { get; set; }

        public List<Hobby> Hobbies { get; set; }

        public List<Language> Languages { get; set; }

        public List<Skills> Skills { get; set; }

        public List<UserAdress> UserAdresses { get; set; }

        public List<Work>Work { get; set; }
    }
}
