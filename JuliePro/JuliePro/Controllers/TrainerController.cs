using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JuliePro.Migrations;
using JuliePro.Models;
using JuliePro.Models.Data;
using JuliePro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JuliePro.Controllers
{
    public class TrainerController : Controller
    {
        private readonly JulieProDbContext _context;

        public TrainerController(JulieProDbContext context)
        {
            _context = context;
        }

        // GET: Trainer
        public async Task<IActionResult> Index()
        {
            List<Trainer> listTrainers = new List<Trainer>();

            listTrainers = _context.Trainer.Include("Speciality").ToList();



            listTrainers = listTrainers.OrderBy(a => a.FirstName).ThenBy(e => e.LastName).ToList();

            //à voir si on doit order par les premières lettres ou pas.
            return View(listTrainers);
        }

        // GET: Trainer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trainer == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer.Include("Speciality")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // GET: Trainer/Create
        public IActionResult Create()
        {
            //var listSpecialities = _context.Specialities.ToList();
            //return View(listSpecialities);
            TrainerVM trainerVM = new TrainerVM();

            trainerVM.SpecialitiesSelectList = _context.Specialities.Select(s => new SelectListItem
            {
                Text = s.Name,
                Value = s.Id.ToString()
            }).OrderBy(i => i.Value);


            return View(trainerVM);

        }
        // POST: Trainer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Photo")] Trainer trainer)
        {

            if (ModelState.IsValid)
            {
                _context.Add(trainer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainer);
        }

        // GET: Trainer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer.FindAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            return View(trainer);
        }

        // POST: Trainer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Photo")] Trainer trainer)
        {
            if (id != trainer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerExists(trainer.Id))
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
            return View(trainer);
        }

        // GET: Trainer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trainer == null)
            {
                return NotFound();
            }

            var trainer = await _context.Trainer.Include("Speciality")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // POST: Trainer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainer = await _context.Trainer.FindAsync(id);
            if (trainer != null)
            {
                _context.Trainer.Remove(trainer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerExists(int id)
        {
            return _context.Trainer.Any(e => e.Id == id);
        }
    }
}
