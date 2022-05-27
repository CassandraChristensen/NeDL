using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSigning
{
    internal class View
    {
        //properties

        public string CustomerName { get; set; }

        public string BookTitle { get; set;}

        public string AuthorName { get; set; }

        public double BookPrice { get; set; }

        public double Tax { get; set; }

        public double Coupon { get; set; }

        public double TaxAmount1 { get; set; }

        public double TaxAmount2 { get; set; }

        public double CouponDollarDiscount { get; set; }

        public double BookTotal1 { get; set;  }

        public double BookTotal2 { get; set; }

        public char BookType { get; set;  }

        public char CheckoutAgain { get; set; }

        public IEnumerable<PersonalModel> personalModels { get; set; }
        public IEnumerable<SignedModel> signedModels { get; set; }

        //Constructors
        public View()
        {
            CustomerName = "";
            BookTitle = "";
            AuthorName = "";
            BookPrice = 0;
            Tax = 0;
            Coupon = 0;
             
        }

        //User input/output
        public void GetValue()
        {

            
            Console.WriteLine("Welcome to checkout. Is your book personalized? Please enter 'y' if yes or an 'n' if no. ");
            BookType = Convert.ToChar(Console.ReadLine());

            if (BookType == 'y' || BookType == 'Y')
            {
                Console.WriteLine("Please enter your name");
                CustomerName = Console.ReadLine();

                Console.WriteLine("Please enter the book title");
                BookTitle = Console.ReadLine();

                Console.WriteLine("Please enter the author's name");
                AuthorName = Console.ReadLine();

                Console.WriteLine("Please enter the book's price");
                BookPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter tax rate in decimal. Example 20% = .20");
                Tax = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter coupon discount in decimal. Example 15% = .15");
                Coupon = Convert.ToDouble(Console.ReadLine());
            }
            else
            {

                Console.WriteLine("Please enter your name");
                CustomerName = Console.ReadLine();

                Console.WriteLine("Please enter the book title");
                BookTitle = Console.ReadLine();

                Console.WriteLine("Please enter the author's name");
                AuthorName = Console.ReadLine();

                Console.WriteLine("Please enter the book's price");
                BookPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter tax rate in decimal. Example 20% = .20");
                Tax = Convert.ToDouble(Console.ReadLine());

                

            }
            Console.WriteLine("Would you like to enter another book for checkout?");
            CheckoutAgain = Convert.ToChar(Console.ReadLine());

        }


        public void GetCoupon()
        {
            Console.WriteLine("Please enter coupon percentage");
            Coupon = Convert.ToDouble(Console.ReadLine());
        }

        
            
        public void Read()
        {
            foreach (PersonalModel apersonal in personalModels)
            {
                Console.WriteLine("Personalized Book: " + apersonal);
            }

            foreach (SignedModel asigned in signedModels)
            {
                Console.WriteLine("Signed Only Book: " + asigned);
            }
        }

        public void ShowResults()
        {
            Console.WriteLine("Tax for Signed Book: " + TaxAmount1);
            Console.WriteLine("Tax for Personalized Book: " + TaxAmount2);
            Console.WriteLine("Coupon dollar discount: " + CouponDollarDiscount);
            Console.WriteLine("Signed Book Total: " + BookTotal1);
            Console.WriteLine("Personalized Book Total: " + BookTotal2);

        }
        


    }
}
