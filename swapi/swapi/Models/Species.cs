using System;
using System.Collections.Generic;
using System.Text;

namespace swapi.Models
{
    public class Species
    {
        public double average_height { get; set; }
        public int average_lifespan { get; set; }
        public string classification { get; set; }
        public DateTime created { get; set; }
        public string designation { get; set; }
        public DateTime edited { get; set; }
        public string eye_colors { get; set; }
        public string hair_colors { get; set; }
        public string homeworld { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public List<People> people { get; set; }
        public List<Film> films { get; set; }
        public string skin_colors { get; set; }
        public string url { get; set; }
    }
}