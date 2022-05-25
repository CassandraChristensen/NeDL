using System;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance (dependency) of one of my object classes
            IScheduler scheduler = new RetirementScheduler();

            //use constructor injection to pass the dependency 
            ProductService productService = new ProductService(scheduler);

            //message to be displayed/passed in. 
            productService.Schedule("Testing");

        }
    }
}
