using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork9
{
    internal class EuroMoney
    {
        public int euro;
        public int cents;
    }
    internal struct DollarMoney
    {
        public int dollars;
        public int cents;
    }

    internal class AdditionFiveCents
    {
        public void AddMoney(ref EuroMoney money)
        {
            money.cents += 5;
        }
        public void AddMoney(ref DollarMoney dollar) 
        { 
            dollar.cents += 5; 
        }
    }
}
