namespace Lesson6
{
    internal class Fibonacci
    {
        int Fib(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(message: "Fibonacci number cannot be negative");
            }
            if (number == 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }

            return Fib(number - 1) + Fib(number - 2);
        }
    }
}
