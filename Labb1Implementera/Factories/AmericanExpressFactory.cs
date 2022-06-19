using Labb1Implementera.CreditCards;
using Labb1Implementera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Factories
{
    public class AmericanExpressFactory : CreditCardFactory
    {
        protected override ICreditCard MakeCard()
        {
            ICreditCard card = new AmericanExpress();
            return card;
        }
    }
}
