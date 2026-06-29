namespace Tourist_Project_MVC.Models
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public int ContactNumber { get; set; }
        public List<Reward>? Rewards { get; set; }
    }
}
