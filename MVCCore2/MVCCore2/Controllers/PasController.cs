using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCCore2.Models;

namespace MVCCore2.Controllers
{
    public class PasController : Controller
    {
        private readonly PsiContext _context;

        public PasController(PsiContext context)
        {
            _context = context;    
        }

        // GET: Pas
        public async Task<IActionResult> Index()
        {
            var psiContext = _context.Pas.Include(p => p.Vrsta);
            return View(await psiContext.ToListAsync());
        }

        // GET: Pas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pas = await _context.Pas
                .Include(p => p.Vrsta)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (pas == null)
            {
                return NotFound();
            }

            return View(pas);
        }

        // GET: Pas/Create
        public IActionResult Create()
        {
            ViewData["VrstaId"] = new SelectList(_context.Set<Vrsta>(), "Id", "Id");
            return View();
        }

        // POST: Pas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,DatRod,VrstaId")] Pas pas)
        {
            //Iskomentirali smo normalni kod i sada ćemo generirati novog psa ručno
            // bez obzira na unos korisnika
            Pas p = new Pas();
            p.Ime = "Fifi";
            p.DatRod = DateTime.Now.AddYears(-1);
            p.VrstaId = 1;
            _context.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
            /*
            if (ModelState.IsValid)
            {
                _context.Add(pas);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
       
            ViewData["VrstaId"] = new SelectList(_context.Set<Vrsta>(), "Id", "Id", pas.VrstaId);
            return View(pas);
            */
        }

        // GET: Pas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pas = await _context.Pas.SingleOrDefaultAsync(m => m.Id == id);
            if (pas == null)
            {
                return NotFound();
            }
            ViewData["VrstaId"] = new SelectList(_context.Set<Vrsta>(), "Id", "Naziv", pas.VrstaId);
            return View(pas);
        }

        // POST: Pas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,DatRod,VrstaId")] Pas pas)
        {
            if (id != pas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PasExists(pas.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["VrstaId"] = new SelectList(_context.Set<Vrsta>(), "Id", "Id", pas.VrstaId);
            return View(pas);
        }

        // GET: Pas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pas = await _context.Pas
                .Include(p => p.Vrsta)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (pas == null)
            {
                return NotFound();
            }

            return View(pas);
        }

        // POST: Pas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pas = await _context.Pas.SingleOrDefaultAsync(m => m.Id == id);
            _context.Pas.Remove(pas);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PasExists(int id)
        {
            return _context.Pas.Any(e => e.Id == id);
        }
    }
}
