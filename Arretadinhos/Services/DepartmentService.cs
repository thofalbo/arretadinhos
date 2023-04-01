namespace Arretadinhos.Services
{
    public class DepartmentService
    {
        private readonly ArretadinhosContext _context;
        public DepartmentService(ArretadinhosContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync() => await _context.Department
            .OrderBy(x => x.Name)
            .ToListAsync();
    }
}