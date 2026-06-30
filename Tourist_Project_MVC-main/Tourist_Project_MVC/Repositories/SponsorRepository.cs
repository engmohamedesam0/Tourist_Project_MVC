using Microsoft.EntityFrameworkCore;
using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class SponsorRepository : Repository<Sponsor>, ISponsorRepository
    {
        private readonly TouristContext context;

        public SponsorRepository(TouristContext context) : base(context)
        {
            this.context = context;
        }

        public Sponsor GetByIdWithRewars(int id)
        {
            Sponsor? sponsorWithRewards = context.Sponsors.Include(s=>s.Rewards).FirstOrDefault(s=>s.Id == id);
            return sponsorWithRewards;
        }
    }
}