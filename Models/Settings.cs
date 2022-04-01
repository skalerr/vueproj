using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace rpg2.Models
{
   public class Settings
{
     public int? Id {get; set; } = 0;

    public int? Summ { get; set; } = 0;

  
    public decimal? Day { get; set; } = 0;


   public string? Title { get; set; } = "String";


   public decimal? PercentDay { get; set; } = 0;

    public decimal? PercentMonth { get; set; } = 0;

    public decimal? PercentYear { get; set; }= 0;



}
}