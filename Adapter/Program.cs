using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //IProductService productService = new ProductService();
            IProductService productService = new AxaptaProductServiceAdapter();

            productService.ListProduct();

            Console.ReadLine();
        }

    }

    interface IProductService
    {
        void ListProduct();
    }


    class ProductService : IProductService
    {
        public void ListProduct()
        {
            Console.WriteLine("Products from database");
        }
    }

    // Adapter Class
    class AxaptaProductServiceAdapter : IProductService
    {
        public void ListProduct()
        {
            var axapta = new AxaptaProductGetter();
            axapta.GetProductList();
        }
    }


    // Adaptee
    // External Service , DLL , Nuget ...etc (This class close World for us)
    class AxaptaProductGetter
    {
        public void GetProductList()
        {
            Console.WriteLine("Products from axapta");
        }
    }


}
