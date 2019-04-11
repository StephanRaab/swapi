using System;
using System.Collections.Generic;
using System.Text;

namespace swapi.Models
{
    public class People
    {
        public string name { get; set; }
        public string birth_year { get; set; }
        public string eye_color { get; set; }
        public string gender { get; set; }
        public string hair_color { get; set; }
        public int height { get; set; }
        public int mass { get; set; }
        public string skin_color { get; set; }
        public string homeworld { get; set; }
        public List<Film> films { get; set; }
        public List<Species> species { get; set; }
        public List<Starship> starships { get; set; }
        public List<Vehicle> vehicles { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
    }
}