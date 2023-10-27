using cw12.Contracts;

namespace cw12.Ducks
{
    internal class RubberDuck : BaseDuck
    {
        public override string DuckType { get; } = "RubberDuck";

        public override string Fly()
        {
            return "Плохо летает";
        }
        public override string Swim()
        {
            return "Плавает";
        }
    }
}
