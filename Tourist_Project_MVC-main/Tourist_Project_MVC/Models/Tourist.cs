namespace Tourist_Project_MVC.Models
{
    public class Tourist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string? IdNumber { get; set; }
        public string? Passport { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int point_Balance { get; set; }
        public DateTime RegisterDate { get; set; }

        public List<TripPlan> TripPlans { get; set; }
        public List<UserMission> UserMissions { get; set; }
        public List<Redemption> Redemptions { get; set; }
    }
}
