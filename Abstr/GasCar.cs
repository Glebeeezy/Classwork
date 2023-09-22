using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr
{
    internal class GasCar : Vichle
    {
        public override void Fuel()
        {
            Console.WriteLine("I am fueled by gas");
        }

        public override void Start()
        {
            Console.WriteLine("Gas car started to move");
        }

        public override void Stop()
        {
            Console.WriteLine("Gas car stoped");
        }
    }
}
