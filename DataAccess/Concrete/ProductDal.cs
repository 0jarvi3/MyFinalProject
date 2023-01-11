﻿using System.Linq.Expressions;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete;

public class ProductDal : EntityRepositoryBase<Product,NorthwindContext>,IProductDal
{
    public List<ProductDetailDto> GetProductDetails()
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var result = from p in context.Products
                join c in context.Categories on p.CategoryId equals c.CategoryId
                select new ProductDetailDto
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryName = c.CategoryName,
                    UnitsInStock = p.UnitsInStock,
                    UnitPrice = p.UnitPrice
                };
            return result.ToList();
        }
    }
}