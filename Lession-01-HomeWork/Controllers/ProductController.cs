using Microsoft.AspNetCore.Mvc;

namespace Lession_01_HomeWork.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductView()
        {
            return View();
        }
    }
}
