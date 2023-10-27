namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();

            employee1.FirstName = "Gleb";
            employee1.LastName = "Malyshev";

            Employee employee2 = new Employee();

            employee2.FirstName = "Gleb";
            employee2.LastName = "Malyshev";

            RecordEmployee recordEmployee = new RecordEmployee(FirsName: "Petya", LastName: "Petrov");

            RecordEmployee recordEmployee1 = new RecordEmployee(FirsName: "Petya", LastName: "Petrov");

            MyStruct myStruct1 = new MyStruct();
            MyStruct myStruct2 = new MyStruct();

            myStruct1.FirstName = "Gleb";
            myStruct1.LastName = "Malyshev";

            myStruct2.FirstName = "Gleb";
            myStruct2.LastName = "Malyshev";

            Console.WriteLine(employee1.Equals(employee2));

            Console.WriteLine(recordEmployee1.Equals(recordEmployee));

            Console.WriteLine(myStruct2.Equals(myStruct1));

            Console.WriteLine(employee1.ToString());
            Console.WriteLine(recordEmployee.ToString());
            Console.WriteLine(myStruct1.ToString());
        }
    }
}