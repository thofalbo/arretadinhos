using Microsoft.AspNetCore.Mvc;

namespace Arretadinhos.Controllers
{
    // [Route("[SalesRecords]")]
    public class SalesRecordsController : Controller
    {
        // private readonly ILogger<SalesRecordsController> _logger;

        // public SalesRecordsController(ILogger<SalesRecordsController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}