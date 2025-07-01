using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab11_LastLession.Models;

namespace Lab11_LastLession.Controllers
{
    public class NmitEmployeesController : Controller
    {
        private readonly NguyenMinhTuanLab11Context _context;

        public NmitEmployeesController(NguyenMinhTuanLab11Context context)
        {
            _context = context;
        }

        // GET: NmitEmployees
        public async Task<IActionResult> NmitIndex()
        {
            return View(await _context.NmitEmployees.ToListAsync());
        }

        // GET: NmitEmployees/Details/5
        public async Task<IActionResult> NmitDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nmitEmployee = await _context.NmitEmployees
                .FirstOrDefaultAsync(m => m.NmitEmpId == id);
            if (nmitEmployee == null)
            {
                return NotFound();
            }

            return View(nmitEmployee);
        }

        // GET: NmitEmployees/Create
        public IActionResult NmitCreate()
        {
            return View();
        }

        // POST: NmitEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NmitCreate([Bind("NmitEmpId,NmitEmpName,NmitEmpLevel,NmitEmpStartDate,NmitEmpStatus")] NmitEmployee nmitEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nmitEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NmitIndex));
            }
            return View(nmitEmployee);
        }

        // GET: NmitEmployees/Edit/5
        public async Task<IActionResult> NmitEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nmitEmployee = await _context.NmitEmployees.FindAsync(id);
            if (nmitEmployee == null)
            {
                return NotFound();
            }
            return View(nmitEmployee);
        }

        // POST: NmitEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NmitEdit(int id, [Bind("NmitEmpId,NmitEmpName,NmitEmpLevel,NmitEmpStartDate,NmitEmpStatus")] NmitEmployee nmitEmployee)
        {
            if (id != nmitEmployee.NmitEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nmitEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NmitEmployeeExists(nmitEmployee.NmitEmpId))
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
            return View(nmitEmployee);
        }

        // GET: NmitEmployees/Delete/5
        public async Task<IActionResult> NmitDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nmitEmployee = await _context.NmitEmployees
                .FirstOrDefaultAsync(m => m.NmitEmpId == id);
            if (nmitEmployee == null)
            {
                return NotFound();
            }

            return View(nmitEmployee);
        }

        // POST: NmitEmployees/Delete/5
        [HttpPost, ActionName("NmitDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nmitEmployee = await _context.NmitEmployees.FindAsync(id);
            if (nmitEmployee != null)
            {
                _context.NmitEmployees.Remove(nmitEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NmitIndex));
        }

        private bool NmitEmployeeExists(int id)
        {
            return _context.NmitEmployees.Any(e => e.NmitEmpId == id);
        }
    }
}
