namespace Lesson5
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int Factorial(int number)
            {
                if (number < 0) 
                {
                    throw new IndexOutOfRangeException("Factorial cannot be negative");
                }

                else if (number == 0)
                {
                    return 1;
                }

                else if (number == 1)
                {
                    return 1;
                }

                return number * Factorial(number - 1);

            }


            var myBank = NationalBank.CreateBank("Tinkoff");

            myBank.PrintName();

            var myNewBank = NationalBank.CreateBank("AlphaBank", "131");

            myNewBank.PrintName();
            myNewBank.PrintVersion();
            Bank.PressService.PrintDirectorName(myBank);
        }
    }
}