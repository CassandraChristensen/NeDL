using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSigning
{
    internal class PersonalModel
    {
       
        public PersonalModel(string CustomerName, string BookTitle, string AuthorName, double BookPrice, double Tax, double Coupon)
        {

        }

        public PersonalModel( ) { }


        List<PersonalModel> personalModels = new List<PersonalModel>();




        private List<PersonalModel> GetPersonalModel(string CustomerName, string BookTitle, string AuthorName, double BookPrice, double tax, double Coupon)
        {
           
            personalModels.Add(new PersonalModel(CustomerName, BookTitle, AuthorName, BookPrice, tax, Coupon));
            return personalModels; 

        }

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
            return ((BookPrice - CalculateCouponDiscount(BookPrice, Coupon)) + CalculateTax(BookPrice, Tax));
        }



        

    }
}
