using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Interface
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeCard();
        public ICreditCard CreateCard()
        {
            return MakeCard();
        }
    }
}
