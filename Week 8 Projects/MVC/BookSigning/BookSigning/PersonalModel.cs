using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSigning
{
    internal class PersonalModel
    {
        
        

        public double CalculateCouponDiscount(double BookPrice, double Coupon)
        {
            
            return BookPrice * Coupon;
        }

        public double CalculateTax(double BookPrice, double Tax)
        {          
            return BookPrice * Tax;
        }

        public double CalculateTotal(double BookPrice, double Coupon, double Tax)
        {
            return (BookPrice - CalculateCouponDiscount(BookPrice, Coupon)) + CalculateTax(BookPrice, Tax);
        }



        

    }
}
