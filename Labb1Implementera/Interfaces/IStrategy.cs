using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Implementera.Interfaces
{
    public interface IStrategy
    {
        //Strategy Pattern. Vi deklarerar en metod som vi använder olika algoritmer i beroende på klassen.
        void AccountAction(decimal a);
    }
}
