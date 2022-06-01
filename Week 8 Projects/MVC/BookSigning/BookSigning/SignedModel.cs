using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSigning
{
    internal class SignedModel
    {
        
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
