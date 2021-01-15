using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IdentityApp.Data;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityApp.Controllers
{
    public class IspitiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IspitiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ispiti
        public async Task<IActionResult> Index(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                ViewBag.Search = search;
                // 1. način pisanja LINQa
                var ispiti = from ispit in _context.Ispit
                             select ispit;
                // 2. način LINQa
                ispiti = ispiti.Where(ispit => ispit.Predmet.Contains(search));

                return View(ispiti.ToList());
            }
            return View(await _context.Ispit.ToListAsync());
        }

        // GET: Ispiti/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ispit = await _context.Ispit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ispit == null)
            {
                return NotFound();
            }

            return View(ispit);
        }

        // GET: Ispiti/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ispiti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Predmet,Datum")] Ispit ispit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ispit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ispit);
        }

        // GET: Ispiti/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ispit = await _context.Ispit.FindAsync(id);
            if (ispit == null)
            {
                return NotFound();
            }
            return View(ispit);
        }

        // POST: Ispiti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Predmet,Datum")] Ispit ispit)
        {
            if (id != ispit.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ispit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IspitExists(ispit.Id))
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
            return View(ispit);
        }

        // GET: Ispiti/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ispit = await _context.Ispit
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ispit == null)
            {
                return NotFound();
            }

            return View(ispit);
        }

        // POST: Ispiti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ispit = await _context.Ispit.FindAsync(id);
            _context.Ispit.Remove(ispit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IspitExists(int id)
        {
            return _context.Ispit.Any(e => e.Id == id);
        }
    }
}
