using System.Linq.Expressions;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class ProductDal : EntityRepositoryBase<Product,NorthwindContext>,IProductDal
{

}