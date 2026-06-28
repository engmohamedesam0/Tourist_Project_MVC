using Microsoft.EntityFrameworkCore;
using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class RewardRepository : Repository<Reward>, IRewardRepository
    {
        public RewardRepository(TouristContext context) : base(context) { }

        public new Reward? GetById(int id)
        {
            return _context.Rewards
                .Include(r => r.Sponsor)
                .FirstOrDefault(r => r.Id == id);
        }
    }
}