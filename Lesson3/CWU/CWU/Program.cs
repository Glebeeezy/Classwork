namespace CWU
{
    internal class Program
    {
        static void Main(string[] args)
        {
               
            void PrintValue(int start, int end )
                 {
                    for (int i = start; i <= end ; i++)
                    {
                        if (i % 2 == 0 & i != 0)
                        {
                            Console.WriteLine(i);
                        }                    
                    }
                 }
            Console.WriteLine("Введите начало");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец");
            int second = int.Parse(Console.ReadLine());
            PrintValue(first,second);
            void Fibonaci(int index, int firstNum = 0, int secondNum = 1, int counter = 2)
            {             
                int result = firstNum + secondNum;
                if (counter == index)
                {
                    Console.WriteLine($"Число фибоначчи под номером {index} равняется {result}");
                }
                else
                {
                    counter++;
                    Fibonaci(index, firstNum = secondNum,secondNum = result, counter);
                }
            }

            Console.WriteLine("Введите номер числа фибоначи которое хотите узнать");
            int number;
            number = int.Parse(Console.ReadLine());
            Fibonaci(number);
        }
    }
}