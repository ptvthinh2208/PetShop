using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PetShopDbContext _context;
        public UnitOfWork(PetShopDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
