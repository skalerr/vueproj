using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace rpg2.Models
{
    public class UserData
    {
        [Key]
        public int? Id {get; set; }
    [JsonProperty("requestnumber")]
        public string? RequestNumber {get; set; }
        public string? inputtel { get; set; }

        public string? inputname { get; set; }
        public string? inputemail { get; set; }

        public int? vmodelsumm { get; set; }
        public int? vmodelday { get; set; }
        
        public string? datenow { get; set; } 
        // = new DateTime();

    }
}