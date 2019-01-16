using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCModelApp.Models;

namespace MVCModelApp.Controllers
{
    public class ProjekcijeController : Controller
    {
        private readonly MVCModelAppContext _context;

        public ProjekcijeController(MVCModelAppContext context)
        {
            _context = context;
        }

        // GET: Projekcije
        public async Task<IActionResult> Index()
        {
            var mVCModelAppContext = _context.Projekcija.Include(p => p.Film).Include(p => p.Kino);
            return View(await mVCModelAppContext.ToListAsync());
        }

        // GET: Projekcije/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projekcija = await _context.Projekcija
                .Include(p => p.Film)
                .Include(p => p.Kino)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projekcija == null)
            {
                return NotFound();
            }

            return View(projekcija);
        }

        // GET: Projekcije/Create
        public IActionResult Create()
        {
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Naziv");
            ViewData["KinoId"] = new SelectList(_context.Kino, "Id", "Naziv");
            return View();
        }

        // POST: Projekcije/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FilmId,KinoId,Datum")] Projekcija projekcija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projekcija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Naziv", projekcija.FilmId);
            ViewData["KinoId"] = new SelectList(_context.Kino, "Id", "Naziv", projekcija.KinoId);
            return View(projekcija);
        }

        // GET: Projekcije/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projekcija = await _context.Projekcija.FindAsync(id);
            if (projekcija == null)
            {
                return NotFound();
            }
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Naziv", projekcija.FilmId);
            ViewData["KinoId"] = new SelectList(_context.Kino, "Id", "Naziv", projekcija.KinoId);
            return View(projekcija);
        }

        // POST: Projekcije/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FilmId,KinoId,Datum")] Projekcija projekcija)
        {
            if (id != projekcija.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projekcija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjekcijaExists(projekcija.Id))
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
            ViewData["FilmId"] = new SelectList(_context.Film, "Id", "Naziv", projekcija.FilmId);
            ViewData["KinoId"] = new SelectList(_context.Kino, "Id", "Naziv", projekcija.KinoId);
            return View(projekcija);
        }

        // GET: Projekcije/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projekcija = await _context.Projekcija
                .Include(p => p.Film)
                .Include(p => p.Kino)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projekcija == null)
            {
                return NotFound();
            }

            return View(projekcija);
        }

        // POST: Projekcije/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projekcija = await _context.Projekcija.FindAsync(id);
            _context.Projekcija.Remove(projekcija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjekcijaExists(int id)
        {
            return _context.Projekcija.Any(e => e.Id == id);
        }
    }
}
