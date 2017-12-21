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
    public class VrstaController : Controller
    {
        private readonly PsiContext _context;

        public VrstaController(PsiContext context)
        {
            _context = context;    
        }

        // GET: Vrsta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vrsta.ToListAsync());
        }

        // GET: Vrsta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrsta = await _context.Vrsta
                .SingleOrDefaultAsync(m => m.Id == id);
            if (vrsta == null)
            {
                return NotFound();
            }

            return View(vrsta);
        }

        // GET: Vrsta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vrsta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv")] Vrsta vrsta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vrsta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vrsta);
        }

        // GET: Vrsta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrsta = await _context.Vrsta.SingleOrDefaultAsync(m => m.Id == id);
            if (vrsta == null)
            {
                return NotFound();
            }
            return View(vrsta);
        }

        // POST: Vrsta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv")] Vrsta vrsta)
        {
            if (id != vrsta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vrsta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VrstaExists(vrsta.Id))
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
            return View(vrsta);
        }

        // GET: Vrsta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vrsta = await _context.Vrsta
                .SingleOrDefaultAsync(m => m.Id == id);
            if (vrsta == null)
            {
                return NotFound();
            }

            return View(vrsta);
        }

        // POST: Vrsta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vrsta = await _context.Vrsta.SingleOrDefaultAsync(m => m.Id == id);
            _context.Vrsta.Remove(vrsta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool VrstaExists(int id)
        {
            return _context.Vrsta.Any(e => e.Id == id);
        }
    }
}
