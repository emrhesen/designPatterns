using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var productManager = ProductManager.CreateSingletonInstanceProductManager();
            productManager.AddProduct();

            Console.ReadLine();
        }
    }

    public class ProductManager
    {
        // singleton object instance
        private static ProductManager productManager;
        static object lockObject = new object();

        // private constructor
        private ProductManager()
        {

        }

        // check singleton object if is null create new one and return.
        public static ProductManager CreateSingletonInstanceProductManager()
        {
            lock(lockObject)
            {
                if (productManager == null)
                {
                    productManager = new ProductManager();
                }
            }

            return productManager;
        }

        public void AddProduct()
        {
            Console.WriteLine("Product Added");
        }
    }

}
