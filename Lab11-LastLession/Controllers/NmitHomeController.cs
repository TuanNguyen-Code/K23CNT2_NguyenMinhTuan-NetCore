using System.Diagnostics;
using Lab11_LastLession.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_LastLession.Controllers
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

        public IActionResult Privacy()
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
