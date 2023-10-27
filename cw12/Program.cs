using cw12.Contracts;
using cw12.Ducks;

namespace cw12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drake drake = new Drake();
            DuckDrone drone = new DuckDrone();
            HoleyRubberDuck holeyRubberDuck = new HoleyRubberDuck();
            RubberDuck rubber = new RubberDuck();

            BaseDuck[] collectionOfDucks = new BaseDuck[] { drake, drone, holeyRubberDuck, rubber };

            foreach (var duck in collectionOfDucks)
            {
                Console.WriteLine($"{duck.DuckType} {duck.Swim()} {duck.Fly()}");              
            }
        }
    }
}