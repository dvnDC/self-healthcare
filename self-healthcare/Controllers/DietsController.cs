#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using self_healthcare.Models;

namespace self_healthcare.Controllers
{
    public class DietsController : Controller
    {
        private readonly SelfHealthcareContext _context;

        public DietsController(SelfHealthcareContext context)
        {
            _context = context;
        }

        // GET: Diets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Diet.ToListAsync());
        }

        // GET: Diets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diet = await _context.Diet
                .FirstOrDefaultAsync(m => m.DietID == id);
            if (diet == null)
            {
                return NotFound();
            }

            return View(diet);
        }

        // GET: Diets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Diets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DietID,Name,ServingSizeGrams,Calories,Inserted")] Diet diet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(diet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(diet);
        }

        // GET: Diets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diet = await _context.Diet.FindAsync(id);
            if (diet == null)
            {
                return NotFound();
            }
            return View(diet);
        }

        // POST: Diets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DietID,Name,ServingSizeGrams,Calories,Inserted")] Diet diet)
        {
            if (id != diet.DietID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(diet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DietExists(diet.DietID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(diet);
        }

        // GET: Diets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diet = await _context.Diet
                .FirstOrDefaultAsync(m => m.DietID == id);
            if (diet == null)
            {
                return NotFound();
            }

            return View(diet);
        }

        // POST: Diets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var diet = await _context.Diet.FindAsync(id);
            _context.Diet.Remove(diet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DietExists(int id)
        {
            return _context.Diet.Any(e => e.DietID == id);
        }
    }
}
