using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Interface
{
    public interface ICreditCard
    {
        string GetCreditCardType();
        decimal GetCreditLimit();
        decimal GetAnnualCost();
    }
}
