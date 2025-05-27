using Microsoft.AspNetCore.Mvc;
using Lession06.Models;

namespace Lession06.Controllers
{
    public class NmitEmployeeController : Controller
    {
        private static List<NmitEmployee> NmitListEmployee = new List<NmitEmployee>()
        {
            new NmitEmployee{NmitId = 1,NmitName = "Nguyễn Minh Tuấn",NmitBirthDay = new DateTime(2005, 02, 04),NmitEmail = "nguyenminhtuan@gmail.com",NmitPhone = "0901234567",NmitSalary = 1500000000,NmitStatus = true },
            new NmitEmployee{NmitId = 2,NmitName = "Tran Thi B",NmitBirthDay = new DateTime(1985, 8, 22),NmitEmail = "tranthib@example.com",NmitPhone = "0912345678",NmitSalary = 18000000,NmitStatus = true},
            new NmitEmployee{NmitId = 3,NmitName = "Tran Thi B",NmitBirthDay = new DateTime(1985, 8, 22),NmitEmail = "tranthib@example.com",NmitPhone = "0912345678",NmitSalary = 18000000,NmitStatus = false},
            new NmitEmployee{NmitId = 4,NmitName = "Tran Thi B",NmitBirthDay = new DateTime(1985, 8, 22),NmitEmail = "tranthib@example.com",NmitPhone = "0912345678",NmitSalary = 18000000,NmitStatus = true},
            new NmitEmployee{NmitId = 5,NmitName = "Tran Thi B",NmitBirthDay = new DateTime(1985, 8, 22),NmitEmail = "tranthib@example.com",NmitPhone = "0912345678",NmitSalary = 18000000,NmitStatus = false},
            new NmitEmployee{NmitId = 6,NmitName = "Tran Thi B",NmitBirthDay = new DateTime(1985, 8, 22),NmitEmail = "tranthib@example.com",NmitPhone = "0912345678",NmitSalary = 18000000,NmitStatus = true}
        };
        public IActionResult Index()
        {   
            return View(NmitListEmployee);
        }
        // GET: NmitEmployee/Edit/5
        public IActionResult Edit(int id)
        {
            var employee = NmitListEmployee.FirstOrDefault(e => e.NmitId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        // POST: NmitEmployee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NmitEmployee employee)
        {
            var existing = NmitListEmployee.FirstOrDefault(e => e.NmitId == employee.NmitId);
            if (existing == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                existing.NmitName = employee.NmitName;
                existing.NmitBirthDay = employee.NmitBirthDay;
                existing.NmitEmail = employee.NmitEmail;
                existing.NmitPhone = employee.NmitPhone;
                existing.NmitSalary = employee.NmitSalary;
                existing.NmitStatus = employee.NmitStatus;

                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: NmitEmployee/Delete/5
        public IActionResult Delete(int id)
        {
            var employee = NmitListEmployee.FirstOrDefault(e => e.NmitId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: NmitEmployee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = NmitListEmployee.FirstOrDefault(e => e.NmitId == id);
            if (employee != null)
            {
                NmitListEmployee.Remove(employee);
            }
            return RedirectToAction("Index");
        }
        // POST: NmitEmployee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NmitEmployee employee)
        {
            if (ModelState.IsValid)
            {
                // Tạo ID mới (tăng tự động)
                employee.NmitId = NmitListEmployee.Any() ? NmitListEmployee.Max(e => e.NmitId) + 1 : 1;
                NmitListEmployee.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        // GET: NmitEmployee/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
