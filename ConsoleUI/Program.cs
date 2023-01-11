using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            ProductManager productManager = new ProductManager(new ProductDal());
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var product in productManager.GetAll().Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
 

        }
    }
}