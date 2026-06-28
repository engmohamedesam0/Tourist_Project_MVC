using Microsoft.EntityFrameworkCore;
using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class MissionRepository : Repository<Mission>, IMissionRepository
    {
        public MissionRepository(TouristContext context) : base(context) { }
        
        public new IEnumerable<Mission> GetAll()
        {
            return _context.Missions.Include(m => m.Destination).ToList();
        }
        public new Mission? GetById(int id)
        {
            return _context.Missions.Include(m => m.Destination).Include(m => m.UserMissions).FirstOrDefault(m => m.Id == id);
        }
    }
}
