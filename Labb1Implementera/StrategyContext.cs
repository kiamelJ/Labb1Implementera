using Labb1Implementera.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera
{
    public class StrategyContext
    {
        private IStrategy BalanceStrategy;

        public void SetBalanceStrategy(IStrategy strategy)
        {
            BalanceStrategy = strategy;
        }

        public void AccountAction(decimal a)
        {
            BalanceStrategy.AccountAction(a);         
        }
    }
}
