using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr
{
    internal class GasolineCar : Vichle
    {
        public override void Fuel()
        {
            Console.WriteLine("I am fueled by gasoline");
        }

        public override void Start()
        {
            Console.WriteLine("Gasoline car start to move");
        }

        public override void Stop() 
        {
            Console.WriteLine("Gasoline car stoped");
        }
    }
}
