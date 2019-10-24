using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPIdentity.Data;
using ASPIdentity.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASPIdentity.Controllers
{
    public class TekmesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TekmesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tekmes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tekme.Include(t => t.Klub1).Include(t => t.Klub2);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tekmes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tekme = await _context.Tekme
                .Include(t => t.Klub1)
                .Include(t => t.Klub2)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tekme == null)
            {
                return NotFound();
            }

            return View(tekme);
        }

        // GET: Tekmes/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["Klub1Id"] = new SelectList(_context.Klub, "Id", "Ime");
            ViewData["Klub2Id"] = new SelectList(_context.Klub, "Id", "Ime");
            return View();
        }

        // POST: Tekmes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Klub1Id,Klub2Id,Datum,Koeficijent")] Tekme tekme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tekme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Klub1Id"] = new SelectList(_context.Klub, "Id", "Ime", tekme.Klub1Id);
            ViewData["Klub2Id"] = new SelectList(_context.Klub, "Id", "Ime", tekme.Klub2Id);
            return View(tekme);
        }

        // GET: Tekmes/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var tekme = await _context.Tekme.FindAsync(id);
            if (tekme == null)
            {
                return NotFound();
            }
            ViewData["Klub1Id"] = new SelectList(_context.Klub, "Id", "Ime", tekme.Klub1Id);
            ViewData["Klub2Id"] = new SelectList(_context.Klub, "Id", "Ime", tekme.Klub2Id);
            return View(tekme);
        }

        // POST: Tekmes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Klub1Id,Klub2Id,Datum,Koeficijent")] Tekme tekme)
        {
            if (id != tekme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tekme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TekmeExists(tekme.Id))
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
            ViewData["Klub1Id"] = new SelectList(_context.Klub, "Id", "Ime", tekme.Klub1Id);
            ViewData["Klub2Id"] = new SelectList(_context.Klub, "Id", "Ime", tekme.Klub2Id);
            return View(tekme);
        }

        // GET: Tekmes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tekme = await _context.Tekme
                .Include(t => t.Klub1)
                .Include(t => t.Klub2)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tekme == null)
            {
                return NotFound();
            }

            return View(tekme);
        }

        // POST: Tekmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tekme = await _context.Tekme.FindAsync(id);
            _context.Tekme.Remove(tekme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TekmeExists(int id)
        {
            return _context.Tekme.Any(e => e.Id == id);
        }
    }
}
