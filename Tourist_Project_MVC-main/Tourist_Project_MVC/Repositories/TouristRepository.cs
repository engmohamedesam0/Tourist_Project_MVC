using Tourist_Project_MVC.Data;
using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public class TouristRepository : Repository<Tourist>, ITouristRepository
    {
        public TouristRepository(TouristContext context) : base(context) { }
    }
}
