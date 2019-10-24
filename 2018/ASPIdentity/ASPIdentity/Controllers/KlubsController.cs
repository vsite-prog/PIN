using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPIdentity.Data;
using ASPIdentity.Models;

namespace ASPIdentity.Controllers
{
    public class KlubsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KlubsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Klubs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Klub.ToListAsync());
        }

        // GET: Klubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klub = await _context.Klub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (klub == null)
            {
                return NotFound();
            }

            return View(klub);
        }

        // GET: Klubs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Klubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Sport")] Klub klub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(klub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(klub);
        }

        // GET: Klubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klub = await _context.Klub.FindAsync(id);
            if (klub == null)
            {
                return NotFound();
            }
            return View(klub);
        }

        // POST: Klubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,Sport")] Klub klub)
        {
            if (id != klub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(klub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KlubExists(klub.Id))
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
            return View(klub);
        }

        // GET: Klubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var klub = await _context.Klub
                .FirstOrDefaultAsync(m => m.Id == id);
            if (klub == null)
            {
                return NotFound();
            }

            return View(klub);
        }

        // POST: Klubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var klub = await _context.Klub.FindAsync(id);
            _context.Klub.Remove(klub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KlubExists(int id)
        {
            return _context.Klub.Any(e => e.Id == id);
        }
    }
}
