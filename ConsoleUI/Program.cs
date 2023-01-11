using Business.Concrete;
using DataAccess.Concrete;

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
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

        }
    }
}