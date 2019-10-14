using ProductsMicroservice.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsMicroservice.Models.DataManager
{
    public class ProductsManager : IDataRepository<Products>
    {
        readonly ProductsContext _productsContext;

        public ProductsManager(ProductsContext context)
        {
            _productsContext = context;
        }

        public IEnumerable<Products> GetAll()
        {
            return _productsContext.Products.ToList();
        }

        public Products Get(long id)
        {
            return _productsContext.Products
                  .FirstOrDefault(e => e.Id == id);
        }

        public void Add(Products entity)
        {
            _productsContext.Products.Add(entity);
            _productsContext.SaveChanges();
        }

        public void Update(Products product, Products entity)
        {
            product.ProductName = entity.ProductName;
            product.Description = entity.Description;
            product.Price = entity.Price;
            

            _productsContext.SaveChanges();
        }

        public void Delete(Products product)
        {
            _productsContext.Products.Remove(product);
            _productsContext.SaveChanges();
        }
    }
}