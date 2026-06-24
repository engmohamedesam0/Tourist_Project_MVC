using System.ComponentModel.DataAnnotations.Schema;

namespace Tourist_Project_MVC.Models
{
    public class Reward
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string RewardType { get; set; }
        public string Description { get; set; }
        public int PointsRequired { get; set; }
        public int QuantityAvailable { get; set; }
        public DateTime ExpirationDate { get; set; }

        [ForeignKey("SponsorId")]
        public int SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }

        List<Redemption> Redemptions { get; set; }
    }
}
