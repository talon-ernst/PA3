using Microsoft.AspNetCore.Mvc;

namespace PA3.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}