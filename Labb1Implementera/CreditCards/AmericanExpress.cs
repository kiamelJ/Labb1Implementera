using Labb1Implementera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.CreditCards
{
    class AmericanExpress : ICreditCard
    {
        public decimal GetAnnualCost()
        {
            return 5000m;
        }

        public string GetCreditCardType()
        {
            return "American Express Centurion";
        }

        public decimal GetCreditLimit()
        {
            return 1000000000m;
        }
    }
}
