using System.Collections.Generic;

namespace TravelApp.Models
{
    public class Destination
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string About { get; set; }
        public List<string> Gallery { get; set; }
    }
}
