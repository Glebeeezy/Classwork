using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr
{
    internal class ElectroCar : Vichle
    {
        public override void Fuel()
        {
            Console.WriteLine("I am charged by electricity");
        }

        public override void Start()
        {
            Console.WriteLine("Electro car start to move");
        }

        public override void Stop()
        {
            Console.WriteLine("Electro car stoped");
        }
    }
}
