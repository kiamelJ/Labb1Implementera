using Labb1Implementera.CreditCards;
using Labb1Implementera.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Factories
{
    public class VisaFactory : CreditCardFactory
    {
        //Factory Method. Respektive kreditkort skapar sitt eget kort.
        protected override ICreditCard MakeCard()
        {
            ICreditCard card = new Visa();
            return card;
        }
    }
}
