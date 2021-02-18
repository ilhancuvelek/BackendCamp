using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            Product ProductToDelete = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);//foreach gibi.LINQ
            _products.Remove(ProductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductId == entity.ProductId);//foreach gibi.LINQ
            ProductToUpdate.ProductName = entity.ProductName;
            ProductToUpdate.CategoryId = entity.CategoryId;
            ProductToUpdate.UnitPrice = entity.UnitPrice;
            ProductToUpdate.UnitsInStock = entity.UnitsInStock;
        }
    }
}
