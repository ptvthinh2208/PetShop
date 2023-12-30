using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Save();
        void Dispose();
    }
}
