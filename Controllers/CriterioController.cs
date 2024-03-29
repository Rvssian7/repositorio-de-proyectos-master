using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repositorio.Models;

namespace repositorio.Controllers
{
    public class CriterioController : Controller
    {
        private readonly RepositorioContext _context;

        public CriterioController(RepositorioContext context)
        {
            _context = context;
        }

        // GET: Criterio
        public async Task<IActionResult> Index()
        {
            return View(await _context.Criterio.ToListAsync());
        }

        // GET: Criterio/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterio = await _context.Criterio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (criterio == null)
            {
                return NotFound();
            }

            return View(criterio);
        }

        // GET: Criterio/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Criterio/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descripción,Id")] Criterio criterio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(criterio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(criterio);
        }

        // GET: Criterio/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterio = await _context.Criterio.FindAsync(id);
            if (criterio == null)
            {
                return NotFound();
            }
            return View(criterio);
        }

        // POST: Criterio/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Descripción,Id")] Criterio criterio)
        {
            if (id != criterio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(criterio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriterioExists(criterio.Id))
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
            return View(criterio);
        }

        // GET: Criterio/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterio = await _context.Criterio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (criterio == null)
            {
                return NotFound();
            }

            return View(criterio);
        }

        // POST: Criterio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var criterio = await _context.Criterio.FindAsync(id);
            _context.Criterio.Remove(criterio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriterioExists(long id)
        {
            return _context.Criterio.Any(e => e.Id == id);
        }
    }
}
