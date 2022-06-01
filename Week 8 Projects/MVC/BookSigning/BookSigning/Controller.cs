using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSigning
{

    internal class Controller
    {
        private PersonalModel personalmodel;



        private SignedModel signedmodel;

        
        

        private View view;

        public Controller()
        {
            do
            {
                
                view = new View();
                
                

                //signedmodel = new SignedModel();
                 view.GetBookType();

                //signedmodel = new SignedModel(view.CustomerName, view.BookTitle, view.AuthorName, view.BookPrice, view.Tax);
                //personalmodel = new PersonalModel(view.CustomerName, view.BookTitle, view.AuthorName, view.BookPrice, view.Tax, view.Coupon);
                 if (view.BookType == 'y' || view.BookType == 'Y')
                 {
                    personalmodel = new PersonalModel();
                    view.GetValue();
                    view.TaxAmount2 = personalmodel.CalculateTax(view.BookPrice, view.Tax);
                    view.CouponDollarDiscount = personalmodel.CalculateCouponDiscount(view.BookPrice, view.Coupon);
                    view.BookTotal2 = personalmodel.CalculateTotal(view.BookPrice, view.Coupon, view.Tax);
                    view.ShowResults();


                 }
                else
                {
                    
                    signedmodel = new SignedModel();
                    view.GetValue();
                    view.TaxAmount1 = signedmodel.CalculateTax(view.BookPrice, view.Tax);
                    view.BookTotal1 = signedmodel.CalculateTotal(view.BookPrice, view.Tax);
                    view.ShowResults();
                }
            } while (view.CheckoutAgain == 'y' || view.CheckoutAgain == 'Y');

            //Something is wrong with my logic. Take a look at it to fix it. 
            


        }
    }
}
