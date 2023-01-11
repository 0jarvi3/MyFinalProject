using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    public List<Category> GetAll(Expression<Func<Category, bool>>? filter)
    {
        throw new NotImplementedException();
    }

    public Category Get(Expression<Func<Category, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public void Add(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category entity)
    {
        throw new NotImplementedException();
    }
}