using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class TripPlanRepository : Repository<TripPlan>, ITripPlanRepository
    {
        public TripPlanRepository(TouristContext context) : base(context) { }
    }
}