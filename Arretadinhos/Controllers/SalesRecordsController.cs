using Microsoft.AspNetCore.Mvc;

namespace Arretadinhos.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}