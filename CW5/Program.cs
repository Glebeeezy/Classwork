namespace CW5
{
    internal class Calculator
    {
        public string name { get;init; }

        private int numberOne { get; set; }

        private int numberTwo { get; set; }

        private void Sum()
        {
            Console.WriteLine($"Сумма сложения: { numberOne + numberTwo}");
        }

        private void Subtraction()
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        private void Multiply()
        {
            Console.WriteLine(numberOne * numberTwo);
        }

        private void Divide()
        {
            Console.WriteLine(numberOne / numberTwo);
        }

        void StartCalc()
        {
            Console.WriteLine("Введите первое число");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введите номер операции которую хотите выполнить \n1: Сложение\t 2: Вычитание\t3: Умножение\t4: Деление");
            int numberOfOperation = int.Parse(Console.ReadLine());
            switch (numberOfOperation)
            {
                case 1: 
                    Sum(); 
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3: 
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
            }
        }
        Calculator(string nameOfCalculator)
        {
            name = nameOfCalculator;
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator("StandartCalc");
            calculator.StartCalc();
            calculator.StartCalc();
            calculator.StartCalc();
            calculator.StartCalc();
            calculator.StartCalc();
            calculator.StartCalc();
            calculator.StartCalc();
        }
    }

}