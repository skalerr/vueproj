using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rpg2.Models
{
    public class UserData
    {
        [Key]
        public int? Id {get; set; }
        public string? requestnumber {get; set; }
        public string? inputtel { get; set; }

        public string? inputname { get; set; }
        public string? inputemail { get; set; }

        public int? vmodelsumm { get; set; }
        public int? vmodelday { get; set; }
        
        public string? datenow { get; set; } 
        // = new DateTime();

    }
}