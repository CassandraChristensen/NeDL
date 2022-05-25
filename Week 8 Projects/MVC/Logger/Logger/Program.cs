using System;

namespace Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new PaperLogger();
            ProductService productService = new ProductService(logger);
            productService.Log("Test");
        }
    }
}
