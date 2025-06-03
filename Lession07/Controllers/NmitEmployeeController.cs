using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lession07.Models;

namespace Lession07.Controllers
{
    public class NmitEmployeeController : Controller
    {
        //mockData
        private static List<NmitEmployee> NmitListEmployees = new List<NmitEmployee>()
        {
            new NmitEmployee
    {
        NmitId = 1,
        NmitName = "Nguyen Van A",
        NmitBirthDay = new DateTime(1990, 5, 15),
        NmitEmail = "nguyenvana@example.com",
        NmitPhone = "0901234567",
        NmitSalary = 15000000,
        NmitStatus = true
    },
    new NmitEmployee
    {
        NmitId = 2,
        NmitName = "Tran Thi B",
        NmitBirthDay = new DateTime(1985, 8, 22),
        NmitEmail = "tranthib@example.com",
        NmitPhone = "0912345678",
        NmitSalary = 18000000,
        NmitStatus = true
    },
    new NmitEmployee
    {
        NmitId = 3,
        NmitName = "Le Van C",
        NmitBirthDay = new DateTime(1995, 12, 10),
        NmitEmail = "levanc@example.com",
        NmitPhone = "0923456789",
        NmitSalary = 12000000,
        NmitStatus = false
    },
    new NmitEmployee
    {
        NmitId = 4,
        NmitName = "Pham Thi D",
        NmitBirthDay = new DateTime(1992, 3, 30),
        NmitEmail = "phamthid@example.com",
        NmitPhone = "0934567890",
        NmitSalary = 20000000,
        NmitStatus = true
    },
    new NmitEmployee
    {
        NmitId = 5,
        NmitName = "Hoang Van E",
        NmitBirthDay = new DateTime(1988, 7, 5),
        NmitEmail = "hoangvane@example.com",
        NmitPhone = "0945678901",
        NmitSalary = 17000000,
        NmitStatus = false
    }
        };
        // GET: NmitEmployeeController
        public ActionResult NmitIndex()
        {
            return View(NmitListEmployees);
        }

        // GET: NmitEmployeeController/Details/5
        public ActionResult NmitDetails(int id)
        {
            var NmitEmployee = NmitListEmployees.FirstOrDefault(e => e.NmitId == id);
            return View(NmitEmployee);
        }

        // GET: NmitEmployeeController/Create
        public ActionResult NmitCreate()
        {
            var NmitListEmployees = new NmitEmployee();
            return View(NmitListEmployees);
        }

        // POST: NmitEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmitCreate(NmitEmployee nmitModel)
        {
            try
            {// Thêm mới nhân viên vào list
                nmitModel.NmitId = NmitListEmployees.Max(x => x.NmitId) + 1;
                NmitListEmployees.Add(nmitModel);
                return RedirectToAction(nameof(NmitIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NmitEmployeeController/Edit/5
        public ActionResult NmitEdit(int id)
        {
            var NmitEmployee = NmitListEmployees.FirstOrDefault(x => x.NmitId == id);
            return View(NmitEmployee);
        }

        // POST: NmitEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmitEdit(int id, NmitEmployee nmitModel)
        {
            try
            {
                for (int i = 0; i < NmitListEmployees.Count(); i++)
                {
                    if (NmitListEmployees[i].NmitId == id)
                    {
                        NmitListEmployees[i] = nmitModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(NmitIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NmitEmployeeController/Delete/5
        public ActionResult NmitDelete(int id)
        {
            var NmitEmployee = NmitListEmployees.FirstOrDefault(e => e.NmitId == id);
            return View(NmitEmployee);
        }

        // POST: NmitEmployeeController/Delete/5
        [HttpPost, ActionName("NmitDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NmitDeleteConfirm(int id)
        {
            try
            {
                var nmitEmployee = NmitListEmployees.FirstOrDefault(e => e.NmitId == id);
                if (nmitEmployee != null)
                {
                    NmitListEmployees.Remove(nmitEmployee); // Xóa đúng object gốc trong danh sách
                }
                return RedirectToAction(nameof(NmitIndex));
            }
            catch
            {
                var employee = NmitListEmployees.FirstOrDefault(e => e.NmitId == id);
                return View(employee);
            }
        }
    }
}
