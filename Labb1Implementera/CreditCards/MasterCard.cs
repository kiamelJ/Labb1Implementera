using Labb1Implementera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.CreditCards
{
    class MasterCard : ICreditCard
    {
        public decimal GetAnnualCost()
        {
            return 600m;
        }

        public string GetCreditCardType()
        {
            return "MasterCard";
        }

        public decimal GetCreditLimit()
        {
            return 100000m;
        }
    }
}
