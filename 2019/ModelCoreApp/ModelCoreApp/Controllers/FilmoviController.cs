using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ModelCoreApp.Models;

namespace ModelCoreApp.Controllers
{
    public class FilmoviController : Controller
    {
        private readonly DB2Context _context;

        public FilmoviController(DB2Context context)
        {
            _context = context;
        }

        // GET: Filmovi
        public async Task<IActionResult> Index()
        {
            var dB2Context = _context.Film.Include(f => f.Zanr);
            return View(await dB2Context.ToListAsync());
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string trazi)
        {
            // LINQ kod za čitanje iz same baze podataka
            var filmovi = from film in _context.Film
                          select film;

            // Provjeri ima li nešto za traženje unutar naziva
            if (!String.IsNullOrEmpty(trazi))
            {
                // Filtriraj
                filmovi = filmovi.Where(f => f.Naziv.Contains(trazi));
            }

            var sviFilmovi = filmovi.Include(f => f.Zanr);

            // POšalji ga u View
            ViewBag.Trazi = trazi;
            return View(filmovi);
        }

        // GET: Filmovi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Zanr)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Filmovi/Create
        public IActionResult Create()
        {
            ViewData["ZanrId"] = new SelectList(_context.Set<Zanr>(), "Id", "Naziv");
            return View();
        }

        // POST: Filmovi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Drzava,DatIzd,ZanrId, Opis")] Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ZanrId"] = new SelectList(_context.Set<Zanr>(), "Id", "Naziv", film.ZanrId);
            return View(film);
        }

        // GET: Filmovi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            ViewData["ZanrId"] = new SelectList(_context.Set<Zanr>(), "Id", "Naziv", film.ZanrId);
            return View(film);
        }

        // POST: Filmovi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Drzava,DatIzd,ZanrId")] Film film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.Id))
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
            ViewData["ZanrId"] = new SelectList(_context.Set<Zanr>(), "Id", "Naziv", film.ZanrId);
            return View(film);
        }

        // GET: Filmovi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Film
                .Include(f => f.Zanr)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Filmovi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Film.FindAsync(id);
            _context.Film.Remove(film);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.Film.Any(e => e.Id == id);
        }
    }
}
