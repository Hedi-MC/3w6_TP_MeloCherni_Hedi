using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.Migrations;

namespace JuliePro.Controllers
{
    public class SpecialityController : Controller
    {
        private readonly JulieProDbContext _context;

        public SpecialityController(JulieProDbContext context)
        {
            _context = context;
        }

        // GET: Speciality
        public async Task<IActionResult> Index()
        {
            List<Trainer> listTrainers = new List<Trainer>();

            listTrainers = _context.Trainer.Include("Speciality").ToList();

            List<Speciality> listSpecialities = new List<Speciality>();

            listSpecialities = _context.Specialities.ToList();

            foreach (Speciality speciality in listSpecialities)
            {
                speciality.Trainers=listTrainers.Where(trainer => trainer.SpecialityId == speciality.Id).OrderBy(a => a.FirstName).ToList();
            }



            listSpecialities = listSpecialities.OrderBy(a => a.Name).ToList();

            //à voir si on doit order par les premières lettres ou pas.
            return View(listSpecialities);
        }

        
        
        // GET: Speciality/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Speciality/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Speciality speciality)
        {
            if (ModelState.IsValid)
            {
                _context.Add(speciality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(speciality);
        }

        // GET: Speciality/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Specialities == null)
            {
                return NotFound();
            }

            var speciality = await _context.Specialities.FindAsync(id);
            if (speciality == null)
            {
                return NotFound();
            }
            return View(speciality);
        }

        // POST: Speciality/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Speciality speciality)
        {
            if (id != speciality.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(speciality);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialityExists(speciality.Id))
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
            return View(speciality);
        }

        // GET: Speciality/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Specialities == null)
            {
                return NotFound();
            }

            var speciality = await _context.Specialities
                .FirstOrDefaultAsync(m => m.Id == id);
            if (speciality == null)
            {
                return NotFound();
            }

            return View(speciality);
        }

        // POST: Speciality/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Specialities == null)
            {
                return Problem("Entity set 'JulieProDbContext.Specialities'  is null.");
            }
            var speciality = await _context.Specialities.FindAsync(id);
            if (speciality != null)
            {
                _context.Specialities.Remove(speciality);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialityExists(int id)
        {
          return (_context.Specialities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
