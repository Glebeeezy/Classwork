namespace Classwork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EuroMoney euro1 = new EuroMoney{ euro = 1, cents = 50};
            EuroMoney euro2 = euro1;

            DollarMoney dollar1 = new DollarMoney { dollars = 1, cents = 50 };
            DollarMoney dollar2 = dollar1;

            AdditionFiveCents add = new AdditionFiveCents();

            add.AddMoney(ref euro1);
            add.AddMoney(ref dollar1);
            Console.WriteLine($"Первый объект {euro1.euro} евро {euro1.cents} центов");
            Console.WriteLine($"Второй объект {euro2.euro} евро {euro2.cents} центов");
            Console.WriteLine($"Первая структура {dollar1.dollars} долларов {dollar1.cents} центов");
            Console.WriteLine($"Вторая структура {dollar2.dollars} долларов {dollar2.cents} центов");

            

        }
    }
}