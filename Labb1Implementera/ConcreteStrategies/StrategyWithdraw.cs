using Labb1Implementera.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.ConcreteStrategies
{
    public class StrategyWithdraw : IStrategy
    {
        //Strategy Pattern. Här instansierar vi metoden för att simulera insättning.
        public void AccountAction(decimal a)
        {
            Console.WriteLine($"You have withdrawn {a.ToString("c0")}");
        }
    }
}
