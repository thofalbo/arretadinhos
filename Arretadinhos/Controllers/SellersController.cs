using Arretadinhos.Models;
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            seller.BirthDate = seller.BirthDate.ToUniversalTime();
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
    }
}