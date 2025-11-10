using Microsoft.AspNetCore.Mvc;

namespace Test_API_DB_Connect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
