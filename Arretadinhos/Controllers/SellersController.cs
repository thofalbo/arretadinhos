using Microsoft.AspNetCore.Mvc;

namespace Arretadinhos.Controllers
{
    // [Route("[Sellers]")]
    public class Sellers : Controller
    {
        private readonly ILogger<Sellers> _logger;

        public Sellers(ILogger<Sellers> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}