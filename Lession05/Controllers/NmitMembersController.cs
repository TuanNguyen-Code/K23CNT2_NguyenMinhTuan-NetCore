using Lession05.Models.NmitData;
using Microsoft.AspNetCore.Mvc;


namespace Lession05.Controllers
{
    public class NmitMembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetMembers()
        {
            List<NmitModels> Members = new List<NmitModels>()
            {
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" },
                new NmitModels { NmitMemberId = Guid.NewGuid().ToString(), NmitUserName = "TuanBay", NmitFullName = "nguyen minh tuan", NmitPassword = "123123123", NmitEmail = "hihi@gmail.com" }
            };
            ViewBag.member = Members;
            return View();
        }
    }
}
