using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TP2.Models;

namespace TP2.Controllers
{
    public class BLController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BLController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bls = _context.BLs.Include(b => b.Containers).ToList();
            return View(bls);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(BL bl)
        {
            if (ModelState.IsValid)
            {
                _context.BLs.Add(bl);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(bl);
        }

        public IActionResult Edit(int id)
        {
            var bl = _context.BLs.Find(id);
            return View(bl);
        }

        [HttpPost]
        public IActionResult Edit(BL bl)
        {
            if (ModelState.IsValid)
            {
                _context.BLs.Update(bl);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(bl);
        }

        public IActionResult Delete(int id)
        {
            var bl = _context.BLs.Find(id);
            return View(bl);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var bl = _context.BLs.Find(id);
            if (bl != null)
            {
                _context.BLs.Remove(bl);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
