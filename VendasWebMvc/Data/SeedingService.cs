using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWebMvc.Models;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Data
{
    public class SeedingService
    {

        private VendasWebMvcContext _context;

        public SeedingService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", 1000.0, new DateTime(1993, 10, 12), d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", 2500.0, new DateTime(1979, 11, 21), d3);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", 1500.0, new DateTime(1995, 10, 15), d2);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", 7000.0, new DateTime(1995, 12, 12), d1);
            Seller s5 = new Seller(5, "Jose da Silva", "ze@gmail.com", 5000.0, new DateTime(1983, 12, 12), d4);
            Seller s6 = new Seller(6, "Ana da Costa", "ana@gmail.com", 500.0, new DateTime(1973, 04, 01), d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 03, 18), 7000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 03, 01), 5000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 04, 20), 34000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 06, 25), 11000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 05, 03), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 07, 04), 7000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 04, 11), 5000.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 12, 21), 34000.0, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 10, 10), 11000.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();
        }

    }
}
