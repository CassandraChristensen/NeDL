using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSigning
{
    internal class SignedModel
    {
        public SignedModel(string CustomerName, string BookTitle, string AuthorName, double BookPrice, double Tax)
        {

        }


        List<SignedModel> signedModels = new List<SignedModel>();


        public SignedModel() { }

        private List<SignedModel> GetSignedModel(string CustomerName, string BookTitle, string AuthorName, double BookPrice, double Tax)
        {

            signedModels.Add(new SignedModel(CustomerName, BookTitle, AuthorName, BookPrice, Tax));
            return signedModels;

        }


        public double CalculateTax(double BookPrice, double Tax)
        {
            return BookPrice * Tax;
        }

        public double CalculateTotal(double BookPrice, double Tax)
        {
            return (BookPrice + CalculateTax(BookPrice, Tax));
        }
    }
}
