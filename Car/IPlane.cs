namespace Classwork12
{
    internal interface IPlane
    {
        public void TakeOff();

        public void Accelerate(int toSpeed);

        public void ClimbTo(int altitude);
    }
}
