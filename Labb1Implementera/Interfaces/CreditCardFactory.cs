using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Interface
{
    public abstract class CreditCardFactory
    {
        //Factory Method. Detta är den abstracta klassen som de olika kreditkorten ärver ifrån i sina factories (ligger i mappen Factories)
        protected abstract ICreditCard MakeCard();
        public ICreditCard CreateCard()
        {
            return MakeCard();
        }
    }
}
