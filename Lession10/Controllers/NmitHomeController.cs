using System.Diagnostics;
using Lession10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lession10.Controllers
{
    public class NmitHomeController : Controller
    {
        private readonly ILogger<NmitHomeController> _logger;

        public NmitHomeController(ILogger<NmitHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NmitIndex()
        {
            return View();
        }

        public IActionResult NmitPrivacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
