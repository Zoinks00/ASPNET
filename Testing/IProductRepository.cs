using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;// ref Models folder

namespace Testing
{
   public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public void DeleteProduct(Product product);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();

    }
}
