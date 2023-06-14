using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project_wira.Data;
using project_wira.Models;

namespace project_wira.Controllers
{
    public class AgensController : Controller
    {
        private readonly project_wiraContext _context;

        public AgensController(project_wiraContext context)
        {
            _context = context;
        }

        // GET: Agens
        public async Task<IActionResult> Index()
        {
              return _context.Agen != null ? 
                          View(await _context.Agen.ToListAsync()) :
                          Problem("Entity set 'project_wiraContext.Agen'  is null.");
        }

        // GET: Agens/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Agen == null)
            {
                return NotFound();
            }

            var agen = await _context.Agen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (agen == null)
            {
                return NotFound();
            }

            return View(agen);
        }

        // GET: Agens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,RegDate,RegStatus,Name,Gender,BirthPlace,BirthDate,Address,Email,Phone,IdCard,CreateDate,CreateBy")] Agen agen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agen);
        }

        // GET: Agens/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Agen == null)
            {
                return NotFound();
            }

            var agen = await _context.Agen.FindAsync(id);
            if (agen == null)
            {
                return NotFound();
            }
            return View(agen);
        }

        // POST: Agens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ID,RegDate,RegStatus,Name,Gender,BirthPlace,BirthDate,Address,Email,Phone,IdCard,CreateDate,CreateBy")] Agen agen)
        {
            if (id != agen.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgenExists(agen.ID))
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
            return View(agen);
        }

        // GET: Agens/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Agen == null)
            {
                return NotFound();
            }

            var agen = await _context.Agen
                .FirstOrDefaultAsync(m => m.ID == id);
            if (agen == null)
            {
                return NotFound();
            }

            return View(agen);
        }

        // POST: Agens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Agen == null)
            {
                return Problem("Entity set 'project_wiraContext.Agen'  is null.");
            }
            var agen = await _context.Agen.FindAsync(id);
            if (agen != null)
            {
                _context.Agen.Remove(agen);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgenExists(long id)
        {
          return (_context.Agen?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
