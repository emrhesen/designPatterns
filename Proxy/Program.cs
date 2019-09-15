using System;
using System.Threading;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProductService _productService = new ProductService();
            IProductService _productService = new ProductServiceProxy(new ProductService());

            Console.WriteLine($"Product Count {_productService.GetProduct()}");

            Console.ReadLine();
        }
    }

    public interface IProductService
    {
        int GetProduct();
    }

    public class ProductService : IProductService
    {
        public int GetProduct()
        {
            Console.WriteLine("Real Service Object");
            return 5;
        }
    }

    public class ProductServiceProxy : IProductService
    {
        private readonly IProductService _productService;

        public ProductServiceProxy(IProductService productService)
        {
            //TO-DO : IoC Container
            _productService = new ProductService();
        }

        public int GetProduct()
        {
            Console.WriteLine("Proxy Service Object");
            return _productService.GetProduct();
        }
    }
}
