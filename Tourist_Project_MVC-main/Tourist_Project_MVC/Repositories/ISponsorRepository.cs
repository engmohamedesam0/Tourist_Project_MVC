using Tourist_Project_MVC.Models;

namespace Tourist_Project_MVC.Repositories
{
    public interface ISponsorRepository : IRepository<Sponsor>
    { 
        public Sponsor GetByIdWithRewars(int id);
    
    }
}
