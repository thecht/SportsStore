using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreMVC.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        public void SaveProduct(Product product);
        public Product DeleteProduct(long productID);
    }
}
