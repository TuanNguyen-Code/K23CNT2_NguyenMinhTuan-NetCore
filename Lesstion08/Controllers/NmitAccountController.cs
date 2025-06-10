using Lesstion08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesstion08.Controllers
{
    public class NmitAccountController : Controller
    {
        private static List<NmitAccount> NmitListAccount = new List<NmitAccount>()
        {
            new NmitAccount
    {
        Id = 1,
        NmitFullName = "Nguyễn Minh Tuấn",
        NmitEmail = "nguyenminhtuan@example.com",
        NmitPhone = "0912345678",
        NmitAddress = "123 Đường Láng, Hà Nội",
        Avarta = "vana.jpg",
        NmitBirthDay = new DateTime(2005, 4, 2),
        NmitGender = "Nam",
        NmitPassword = "123456",
        NmitFacebook = "https://facebook.com/nguyenminhtuan"
    },
    new NmitAccount
    {
        Id = 2,
        NmitFullName = "Trần Thị B",
        NmitEmail = "thib@example.com",
        NmitPhone = "0987654321",
        NmitAddress = "456 Cầu Giấy, Hà Nội",
        Avarta = "thib.jpg",
        NmitBirthDay = new DateTime(1992, 6, 10),
        NmitGender = "Nữ",
        NmitPassword = "abc123",
        NmitFacebook = "https://facebook.com/tranthib"
    },
    new NmitAccount
    {
        Id = 3,
        NmitFullName = "Lê Văn C",
        NmitEmail = "vanc@example.com",
        NmitPhone = "0909090909",
        NmitAddress = "789 Kim Mã, Hà Nội",
        Avarta = "vanc.jpg",
        NmitBirthDay = new DateTime(1990, 1, 20),
        NmitGender = "Nam",
        NmitPassword = "pass123",
        NmitFacebook = "https://facebook.com/levanc"
    },
    new NmitAccount
    {
        Id = 4,
        NmitFullName = "Phạm Thị D",
        NmitEmail = "thid@example.com",
        NmitPhone = "0939393939",
        NmitAddress = "1010 Hoàng Quốc Việt, Hà Nội",
        Avarta = "thid.jpg",
        NmitBirthDay = new DateTime(1998, 12, 5),
        NmitGender = "Nữ",
        NmitPassword = "987654",
        NmitFacebook = "https://facebook.com/phamthid"
    },
    new NmitAccount
    {
        Id = 5,
        NmitFullName = "Đỗ Minh E",
        NmitEmail = "minhe@example.com",
        NmitPhone = "0944949494",
        NmitAddress = "1212 Nguyễn Trãi, Hà Nội",
        Avarta = "minhe.jpg",
        NmitBirthDay = new DateTime(1993, 9, 15),
        NmitGender = "Nam",
        NmitPassword = "doe123",
        NmitFacebook = "https://facebook.com/dominhe"
    },
    new NmitAccount
    {
        Id = 6,
        NmitFullName = "Hoàng Thị F",
        NmitEmail = "thif@example.com",
        NmitPhone = "0955955955",
        NmitAddress = "1414 Tây Sơn, Hà Nội",
        Avarta = "thif.jpg",
        NmitBirthDay = new DateTime(1991, 3, 8),
        NmitGender = "Nữ",
        NmitPassword = "hoangf2024",
        NmitFacebook = "https://facebook.com/hoangthif"
    },
    new NmitAccount
    {
        Id = 7,
        NmitFullName = "Vũ Văn G",
        NmitEmail = "vang@example.com",
        NmitPhone = "0966969696",
        NmitAddress = "1616 Trần Duy Hưng, Hà Nội",
        Avarta = "vang.jpg",
        NmitBirthDay = new DateTime(1989, 11, 30),
        NmitGender = "Nam",
        NmitPassword = "vangpass",
        NmitFacebook = "https://facebook.com/vuvang"
    }
        };
        // GET: NmitAccountController
        public ActionResult NmitIndex()
        {
            return View(NmitListAccount);
        }

        // GET: NmitAccountController/Details/5
        public ActionResult NmitDetails(int id)
        {
            var NmitDetail = NmitListAccount.FirstOrDefault(e => e.Id == id);
            return View(NmitDetail);
        }

        // GET: NmitAccountController/Create
        public ActionResult NmitCreate()
        {
            var NmitModel = new NmitAccount();
            return View(NmitModel);
        }

        // POST: NmitAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmitCreate(NmitAccount nmitModel)
        {
            try
            {
                nmitModel.Id = NmitListAccount.Max(x => x.Id) + 1;
                NmitListAccount.Add(nmitModel);
                return RedirectToAction(nameof(NmitIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NmitAccountController/Edit/5
        public ActionResult NmitEdit(int id)
        {
            var NmitEdit = NmitListAccount.FirstOrDefault(x => x.Id == id);
            return View(NmitEdit);
        }

        // POST: NmitAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NmitEdit(int id, NmitAccount nmitModel)
        {
            try
            {
                for (int i = 0; i < NmitListAccount.Count(); i++)
                {
                    if (NmitListAccount[i].Id == id)
                    {
                        NmitListAccount[i] = nmitModel;
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

        // GET: NmitAccountController/Delete/5
        public ActionResult NmitDelete(int id)
        {
            var NmitDeletes = NmitListAccount.FirstOrDefault(e => e.Id == id);
            return View(NmitDeletes);
        }

        // POST: NmitAccountController/Delete/5
        [HttpPost, ActionName("NmitDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult NmitDelete(int id, IFormCollection collection)
        {
            try
            {
                var nmitEmployee = NmitListAccount.FirstOrDefault(e => e.Id == id);
                if (nmitEmployee != null)
                {
                    NmitListAccount.Remove(nmitEmployee); // Xóa đúng object gốc trong danh sách
                }
                return RedirectToAction(nameof(NmitIndex));
            }
            catch
            {
                var account = NmitListAccount.FirstOrDefault(e => e.Id == id);
                return View(account);
            }
        }
    }
}
