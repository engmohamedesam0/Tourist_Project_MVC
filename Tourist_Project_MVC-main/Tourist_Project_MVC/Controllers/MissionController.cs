using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Tourist_Project_MVC.Models;
using Tourist_Project_MVC.Repositories;
using Tourist_Project_MVC.View_Model;

namespace Tourist_Project_MVC.Controllers
{
    public class MissionController : Controller
    {
        private readonly IMissionRepository missionRepo;
        private readonly IDestinationRepository destRepo;

        public MissionController(IMissionRepository missionRepo, IDestinationRepository destRepo)
        {
            this.missionRepo = missionRepo;
            this.destRepo = destRepo;
        }
        public IActionResult Index()
        {
            var missions = missionRepo.GetAll();
            return View(missions);
        }
        public IActionResult Details(int id)
        {
            Mission mission = missionRepo.GetById(id);
            if(mission != null)
            {
                return View(mission);
            }
            return NotFound();
        }

        public IActionResult Create() 
        {
            MissionWithDeptListVM mission = new MissionWithDeptListVM();
            List<Destination> destinations = destRepo.GetAll().ToList();
            mission.destinations = destinations;
            return View(mission);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MissionWithDeptListVM missionFromReq) 
        {
            if (ModelState.IsValid) 
            {
                Mission mission = new()
                {
                    Title = missionFromReq.Title,
                    MissionType = missionFromReq.MissionType,
                    Description = missionFromReq.Description,
                    PointsReward = missionFromReq.PointsReward,
                    DestinationId = missionFromReq.DestinationId
                };
                //Add
                missionRepo.Add(mission);
                missionRepo.Save();
                return RedirectToAction("Index");
            }
            //return to the view with the list of destinations
            List<Destination> destinations = destRepo.GetAll().ToList();
            missionFromReq.destinations = destinations;
            return View(missionFromReq);
        }
        public IActionResult Edit(int id) 
        {
            Mission missionFromDb = missionRepo.GetById(id);
            if (missionFromDb == null)
            {
                return NotFound();
            }
            MissionWithDeptListVM mission = new()
            {
                Id = missionFromDb.Id,
                Title = missionFromDb.Title,
                MissionType= missionFromDb.MissionType,
                PointsReward = missionFromDb.PointsReward,
                Description = missionFromDb.Description,
                DestinationId = missionFromDb.DestinationId,
            };
            List<Destination> destinations = destRepo.GetAll().ToList();
            mission.destinations = destinations;
            return View(mission);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(MissionWithDeptListVM missionFromReq) 
        {
            if (ModelState.IsValid) 
            {
                Mission mission = new()
                {
                    Id = missionFromReq.Id,
                    Title = missionFromReq.Title,
                    MissionType = missionFromReq.MissionType,
                    Description = missionFromReq.Description,
                    PointsReward = missionFromReq.PointsReward,
                    DestinationId = missionFromReq.DestinationId
                };
                //update
                missionRepo.Update(mission);
                missionRepo.Save();
                return RedirectToAction("Index");

            }
            List<Destination> destinations = destRepo.GetAll().ToList();
            missionFromReq.destinations = destinations;
            return View(missionFromReq);

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Mission missionFromDb = missionRepo.GetById(id);
            return View(missionFromDb);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            missionRepo.Delete(id);
            missionRepo.Save();
            return RedirectToAction("Index");
        }
    }
}
