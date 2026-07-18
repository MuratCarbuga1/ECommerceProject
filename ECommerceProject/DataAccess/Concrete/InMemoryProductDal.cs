using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.DataAccess.Abstract;
using ECommerceProject.Entities.Concrete;

namespace ECommerceProject.DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1, CategoryId = 1, ProductName = "Cup", UnitPrice = 15, UnitsInStock = 150},
                new Product {ProductId = 2, CategoryId = 1, ProductName = "Camera", UnitPrice = 500, UnitsInStock = 3},
                new Product {ProductId = 3, CategoryId = 2, ProductName = "Phone", UnitPrice = 1500, UnitsInStock = 2},
                new Product {ProductId = 4, CategoryId = 2, ProductName = "Keyboard", UnitPrice = 150, UnitsInStock = 65},
                new Product {ProductId = 5, CategoryId = 2, ProductName = "Mouse", UnitPrice = 85, UnitsInStock = 1}
            };
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product entity)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);
            productToUpdate.ProductName = entity.ProductName;
            productToUpdate.CategoryId = entity.CategoryId;
            productToUpdate.UnitPrice = entity.UnitPrice;
            productToUpdate.UnitsInStock = entity.UnitsInStock;
        }
    }
}