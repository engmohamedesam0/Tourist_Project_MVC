using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class RewardRepository : Repository<Reward>, IRewardRepository
    {
        public RewardRepository(TouristContext context) : base(context) { }
    }
}