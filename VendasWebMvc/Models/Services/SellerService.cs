using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Data;

namespace VendasWebMvc.Models.Services
{
    public class SellerService
    {

        private readonly VendasWebMvcContext _context;

        public SellerService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
