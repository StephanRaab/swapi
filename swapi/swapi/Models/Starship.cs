using System;
using System.Collections.Generic;
using System.Text;

namespace swapi.Models
{
    public class Starship
    {
        public string name { get; set; }
        public string model { get; set; }
        public string starship_class { get; set; }
        public string manufacturer { get; set; }
        public long cost_in_credits { get; set; }
        public double length { get; set; }
        public long crew { get; set; }
        public long passengers { get; set; }
        public string max_atmosphering_speed { get; set; }
        public double hyperdrive_rating { get; set; }
        public string MGLT { get; set; }
        public long cargo_capacity { get; set; }
        public string consumables { get; set; }
        public List<Film> films { get; set; }
        public List<People> pilots { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
    }
}