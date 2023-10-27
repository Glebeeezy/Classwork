using cw12.Contracts;

namespace cw12.Ducks
{
    internal class Drake : BaseDuck
    {
        public override sealed string DuckType { get; } = "Drake";

        public override string Swim()
        {
            return "Плавает";
        }
    }
}
