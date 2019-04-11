using System;
using System.Collections.Generic;
using System.Text;

namespace swapi.Models
{
    public class Planet
    {
        public string name { get; set; }
        public long diameter { get; set; }
        public string rotation_period { get; set; }
        public int orbital_period { get; set; }
        public float gravity { get; set; }
        public long population { get; set; }
        public string climate { get; set; }
        public string terrain { get; set; }
        public int surface_water { get; set; }
        public List<People> residents { get; set; }
        public List<Film> films { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
    }
}