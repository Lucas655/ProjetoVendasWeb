using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Data;

namespace VendasWebMvc.Models.Services
{
    public class DepartmentService
    {

        private readonly VendasWebMvcContext _context;

        public DepartmentService(VendasWebMvcContext context)
        {
            _context = context;
        }


        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
