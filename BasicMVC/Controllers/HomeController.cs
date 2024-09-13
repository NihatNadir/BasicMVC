using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "CustomerOrders");
        }
    }
}
