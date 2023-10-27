namespace Classwork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boeing747 boeing = new();

            boeing.Accelerate(400);
            boeing.TakeOff();
            boeing.Accelerate(800);
            boeing.ClimbTo(10000);
        }
    }
}