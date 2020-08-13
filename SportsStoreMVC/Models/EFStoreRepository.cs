using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        public IQueryable<Product> Products => context.Products;

        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

    }
}
