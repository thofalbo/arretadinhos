using Arretadinhos.Models;

namespace Arretadinhos.Services
{
    public class SellerService
    {
        private readonly ArretadinhosContext _context;
        public SellerService(ArretadinhosContext context)
        {
            _context = context;
        }
    }
}