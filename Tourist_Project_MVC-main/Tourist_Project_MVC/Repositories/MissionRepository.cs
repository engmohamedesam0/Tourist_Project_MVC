using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class MissionRepository : Repository<Mission>, IMissionRepository
    {
        public MissionRepository(TouristContext context) : base(context) { }
    }
}
