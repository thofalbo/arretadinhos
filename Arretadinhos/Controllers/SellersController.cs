using Arretadinhos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Arretadinhos.Controllers
{
    // [Route("[Sellers]")]
    public class SellersController : Controller
    {
        // private readonly ILogger<Sellers> _logger;

        // public Sellers(ILogger<Sellers> logger)
        // {
        //     _logger = logger;
        // }

        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}