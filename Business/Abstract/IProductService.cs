using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();//burdaki T->List<Product>
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Entities.DTOs.ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);//burdaki T->Product
        IResult Add(Product product);//bunda void olduğu için IResult
    }
}
