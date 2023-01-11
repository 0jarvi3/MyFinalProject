using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public IDataResult<List<Product>> GetAll()
    {
        if (DateTime.Now.Hour == 12)
        {
            return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
        }

        var result = _productDal.GetAll();
        return new SuccessDataResult<List<Product>>(result,Messages.ProductListed);
    }

    public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
    {
        var result = _productDal.GetAll(p => p.CategoryId == categoryId);
        return new SuccessDataResult<List<Product>>(result);
    }

    public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
    {
        var result = _productDal.GetAll(p => p.UnitPrice <= max && p.UnitPrice >= min);
        return new SuccessDataResult<List<Product>>(result);
    }

    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        var result = _productDal.GetProductDetails();
        return new SuccessDataResult<List<ProductDetailDto>>(result);
    }

    public IResult Add(Product product)
    {
        if (product.ProductName.Length < 2)
        {
            return new ErrorResult(Messages.ProductNameInvalid);
        }

        _productDal.Add(product);
        return new Result(true, Messages.ProductAdded);
    }

    public IDataResult<Product> GetById(int productId)
    {
        var result = _productDal.Get(p => p.ProductId == productId);
        return new SuccessDataResult<Product>(result);
    }
}