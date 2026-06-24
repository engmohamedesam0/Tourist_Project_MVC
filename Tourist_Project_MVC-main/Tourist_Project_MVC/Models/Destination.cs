using System.ComponentModel.DataAnnotations;

namespace Tourist_Project_MVC.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime? OpeningHours { get; set; }
 
        public string? Category { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
        public string? description { get; set; }
        public decimal? TicketPrice { get; set; }

        List<Mission> Missions { get; set; }
        List<TripDestination> TripDestinations { get; set; }
    }
}
