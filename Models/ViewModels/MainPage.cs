using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models.ViewModels
{
    public class MainPage
    {
        public IEnumerable<UserDetails> UserDetails { get; set; }
        public IEnumerable<About> Abouts { get; set; }
        public IEnumerable<Courses> Courses { get; set; }
        public IEnumerable<Hobby> Hobbies { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Skills> Skills { get; set; }
        public IEnumerable<UserAdress> UserAdresses { get; set; }
        public IEnumerable<Work> Works { get; set; }

    }
}
