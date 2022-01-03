using System.Collections.Generic;
using TravelApp.Models;

namespace TravelApp.Services
{
    public class DestinationService
    {
        static DestinationService _instance;

        public static DestinationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DestinationService();

                return _instance;
            }
        }

        public List<Destination> RecommendedDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Japan Temple", Place = "Osaka Street, Japan", Image = "destination1.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                    new Destination { Name = "Torii Gate", Place = "Tokyo Street, Japan", Image = "destination2.jpg", Price = 90, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                    new Destination { Name = "Japan Street", Place = "Japan", Image = "destination3.jpg", Price = 60, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                    new Destination { Name = "Japan Street", Place = "Japan", Image = "destination4.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                };
            }
        }

        public List<Destination> TopDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Japan Street", Place = "Japan", Image = "destination3.jpg", Price = 60, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                    new Destination { Name = "Japan Street", Place = "Japan", Image = "destination4.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                    new Destination { Name = "Japan Temple", Place = "Osaka Street, Japan", Image = "destination1.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                    new Destination { Name = "Torii Gate", Place = "Tokyo Street, Japan", Image = "destination2.jpg", Price = 90, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos." },
                };
            }
        }
    }
}