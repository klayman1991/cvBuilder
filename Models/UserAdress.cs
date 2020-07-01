using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvNetCore2.Models
{
    public class UserAdress
    {


        public int UserAdressID { get; set; }

        [Required(ErrorMessage = "Please enter at least one line of the adress")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "City name required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Postocode required")]
        public string Postcode { get; set; }

    }
}
