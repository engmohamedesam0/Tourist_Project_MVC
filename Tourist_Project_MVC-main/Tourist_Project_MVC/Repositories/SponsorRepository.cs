using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class SponsorRepository : Repository<Sponsor>, ISponsorRepository
    {
        public SponsorRepository(TouristContext context) : base(context) { }
    }
}