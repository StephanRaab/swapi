using System;
using System.Collections.Generic;
using System.Text;

namespace swapi.Models
{
    public class Vehicle
    {
        public int cargo_capacity { get; set; }
        public string consumables { get; set; }
        public long cost_in_credits { get; set; }
        public DateTime created { get; set; }
        public int crew { get; set; }
        public DateTime edited { get; set; }
        public double length { get; set; }
        public string manufacturer { get; set; }
        public long max_atmosphering_speed { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public int passengers { get; set; }
        public List<People> pilots { get; set; }
        public List<Film> films { get; set; }
        public string url { get; set; }
        public string vehicle_class { get; set; }
    }
}