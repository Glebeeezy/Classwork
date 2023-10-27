using cw12.Contracts;

namespace cw12.Ducks
{
    internal class DuckDrone : BaseDuck
    {
        public override sealed string DuckType { get; } = "DuckDrone";

        public override string Swim()
        {
            return  "Плавает";
        }
    }
}
