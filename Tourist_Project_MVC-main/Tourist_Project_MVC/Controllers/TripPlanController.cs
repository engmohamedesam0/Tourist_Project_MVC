using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tourist_Project_MVC.Models;
using Tourist_Project_MVC.Repositories;

namespace Tourist_Project_MVC.Controllers
{
    public class TripPlanController : Controller
    {
        private readonly ITripPlanRepository _repo;
        private readonly ITouristRepository _touristRepo;

        public TripPlanController(ITripPlanRepository repo, ITouristRepository touristRepo)
        {
            _repo = repo;
            _touristRepo = touristRepo;
        }

        public IActionResult Index()
        {
            var trips = _repo.GetAll();
            return View(trips);
        }

        public IActionResult Details(int id)
        {
            var trip = _repo.GetById(id);
            if (trip == null) return NotFound();
            return View(trip);
        }

        public IActionResult Create()
        {
            ViewBag.Tourists = new SelectList(_touristRepo.GetAll(), "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TripPlan trip)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(trip);
                _repo.Save();
                return RedirectToAction("Index");
            }
            ViewBag.Tourists = new SelectList(_touristRepo.GetAll(), "Id", "Name");
            return View(trip);
        }

        public IActionResult Edit(int id)
        {
            var trip = _repo.GetById(id);
            if (trip == null) return NotFound();
            ViewBag.Tourists = new SelectList(_touristRepo.GetAll(), "Id", "Name", trip.TouristId);
            return View(trip);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TripPlan trip)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(trip);
                _repo.Save();
                return RedirectToAction("Index");
            }
            ViewBag.Tourists = new SelectList(_touristRepo.GetAll(), "Id", "Name", trip.TouristId);
            return View(trip);
        }

        public IActionResult Delete(int id)
        {
            var trip = _repo.GetById(id);
            if (trip == null) return NotFound();
            return View(trip);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            _repo.Save();
            return RedirectToAction("Index");
        }
    }
}