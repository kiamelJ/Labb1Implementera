using Labb1Implementera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.CreditCards
{
    class Visa : ICreditCard
    {
        public decimal GetAnnualCost()
        {
            return 500m;
        }

        public string GetCreditCardType()
        {
            return "Visa";
        }

        public decimal GetCreditLimit()
        {
            return 50000m;
        }
    }
}
