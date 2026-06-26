using Microsoft.AspNetCore.Mvc;
using Tourist_Project_MVC.Models;
using Tourist_Project_MVC.Repositories;

namespace Tourist_Project_MVC.Controllers
{
    public class TouristController : Controller
    {
        private readonly ITouristRepository _repo;

        public TouristController(ITouristRepository repo)
        {
            _repo = repo;
        }

        // GET: /Tourist/Index
        public IActionResult Index()
        {
            var tourists = _repo.GetAll();
            return View(tourists);
        }

        // GET: /Tourist/Details/5
        public IActionResult Details(int id)
        {
            var tourist = _repo.GetById(id);
            if (tourist == null) return NotFound();
            return View(tourist);
        }

        // GET: /Tourist/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Tourist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tourist tourist)
        {
            if (ModelState.IsValid)
            {
                tourist.RegisterDate = DateTime.Now;
                _repo.Add(tourist);
                _repo.Save();
                return RedirectToAction("Index");
            }
            return View(tourist);
        }

        // GET: /Tourist/Edit/5
        public IActionResult Edit(int id)
        {
            var tourist = _repo.GetById(id);
            if (tourist == null) return NotFound();
            return View(tourist);
        }

        // POST: /Tourist/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tourist tourist)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(tourist);
                _repo.Save();
                return RedirectToAction("Index");
            }
            return View(tourist);
        }

        // GET: /Tourist/Delete/5
        public IActionResult Delete(int id)
        {
            var tourist = _repo.GetById(id);
            if (tourist == null) return NotFound();
            return View(tourist);
        }

        // POST: /Tourist/Delete/5
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