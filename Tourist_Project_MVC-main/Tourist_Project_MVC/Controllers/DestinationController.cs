using Microsoft.AspNetCore.Mvc;
using Tourist_Project_MVC.Models;
using Tourist_Project_MVC.Repositories;

namespace Tourist_Project_MVC.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationRepository _repo;

        public DestinationController(IDestinationRepository repo)
        {
            _repo = repo;
        }

        // GET: /Destination/Index
        public IActionResult Index()
        {
            var destinations = _repo.GetAll();
            return View(destinations);
        }

        // GET: /Destination/Details/5
        public IActionResult Details(int id)
        {
            var destination = _repo.GetById(id);
            if (destination == null) return NotFound();
            return View(destination);
        }

        // GET: /Destination/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Destination/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Destination destination)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(destination);
                _repo.Save();
                return RedirectToAction("Index");
            }
            return View(destination);
        }

        // GET: /Destination/Edit/5
        public IActionResult Edit(int id)
        {
            var destination = _repo.GetById(id);
            if (destination == null) return NotFound();
            return View(destination);
        }

        // POST: /Destination/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Destination destination)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(destination);
                _repo.Save();
                return RedirectToAction("Index");
            }
            return View(destination);
        }

        // GET: /Destination/Delete/5
        public IActionResult Delete(int id)
        {
            var destination = _repo.GetById(id);
            if (destination == null) return NotFound();
            return View(destination);
        }

        // POST: /Destination/Delete/5
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