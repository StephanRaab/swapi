using System;
using System.Collections.Generic;
using System.Text;

namespace swapi.Models
{
    public class Film
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string producer { get; set; }
        public DateTime release_date { get; set; }
        public List<string> species { get; set; }
        public List<string> starships { get; set; }
        public List<string> vehicles { get; set; }
        public List<string> characters { get; set; }
        public List<string> planets { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public string edited { get; set; }
    }
}