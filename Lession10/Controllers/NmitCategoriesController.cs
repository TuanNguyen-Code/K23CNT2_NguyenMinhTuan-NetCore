using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lession10.Models;

namespace Lession10.Controllers
{
    public class NmitCategoriesController : Controller
    {
        private readonly NmitLession10DbContext _context;

        public NmitCategoriesController(NmitLession10DbContext context)
        {
            _context = context;
        }

        // GET: NmitCategories
        public async Task<IActionResult> NmitIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: NmitCategories/Details/5
        public async Task<IActionResult> NmitDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: NmitCategories/Create
        public IActionResult NmitCreate()
        {
            return View();
        }

        // POST: NmitCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NmitCreate([Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NmitIndex));
            }
            return View(category);
        }

        // GET: NmitCategories/Edit/5
        public async Task<IActionResult> NmitEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: NmitCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NmitEdit(int id, [Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (id != category.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NmitIndex));
            }
            return View(category);
        }

        // GET: NmitCategories/Delete/5
        public async Task<IActionResult> NmitDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: NmitCategories/Delete/5
        [HttpPost, ActionName("NmitDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NmitIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CateId == id);
        }
    }
}
