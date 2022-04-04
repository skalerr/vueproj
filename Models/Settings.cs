using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace rpg2.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }

      [JsonPropertyName("summ")]

        public int? Summ { get; set; }

      [JsonPropertyName("day")]

        public decimal? Day { get; set; }

        // [JsonProperty("title")]
        public string? Title { get; set; }
         [JsonPropertyName("percentDay")]
        public decimal? PercentDay { get; set; }

        public decimal? PercentMonth { get; set; }

        public decimal? PercentYear { get; set; }
    }
}