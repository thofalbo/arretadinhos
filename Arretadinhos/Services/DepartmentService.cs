using Arretadinhos.Models;

namespace Arretadinhos.Services
{
    public class DepartmentService
    {
        private readonly ArretadinhosContext _context;
        public DepartmentService(ArretadinhosContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}