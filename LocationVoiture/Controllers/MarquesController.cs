﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocationVoiture.Data;
using LocationVoiture.Models;

namespace LocationVoiture.Controllers
{
    public class MarquesController : Controller
    {
        private readonly AppDbContext _context;

        public MarquesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Marques
        public async Task<IActionResult> Index()
        {
              return _context.Marques != null ? 
                          View(await _context.Marques.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Marques'  is null.");
        }

        // GET: Marques/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Marques == null)
            {
                return NotFound();
            }

            var marque = await _context.Marques
                .FirstOrDefaultAsync(m => m.MarqueId == id);
            if (marque == null)
            {
                return NotFound();
            }

            return View(marque);
        }

        // GET: Marques/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Marques/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarqueId,Libelle")] Marque marque)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marque);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(marque);
        }

        // GET: Marques/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Marques == null)
            {
                return NotFound();
            }

            var marque = await _context.Marques.FindAsync(id);
            if (marque == null)
            {
                return NotFound();
            }
            return View(marque);
        }

        // POST: Marques/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarqueId,Libelle")] Marque marque)
        {
            if (id != marque.MarqueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marque);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarqueExists(marque.MarqueId))
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
            return View(marque);
        }

        // GET: Marques/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Marques == null)
            {
                return NotFound();
            }

            var marque = await _context.Marques
                .FirstOrDefaultAsync(m => m.MarqueId == id);
            if (marque == null)
            {
                return NotFound();
            }

            return View(marque);
        }

        // POST: Marques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Marques == null)
            {
                return Problem("Entity set 'AppDbContext.Marques'  is null.");
            }
            var marque = await _context.Marques.FindAsync(id);
            if (marque != null)
            {
                _context.Marques.Remove(marque);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarqueExists(int id)
        {
          return (_context.Marques?.Any(e => e.MarqueId == id)).GetValueOrDefault();
        }
    }
}
