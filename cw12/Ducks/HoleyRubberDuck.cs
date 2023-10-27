namespace cw12.Ducks
{
    internal class HoleyRubberDuck : RubberDuck
    {
        public override sealed string DuckType { get; } = "HoleyRubberDuck";
        public override string Swim()
        {
            return "Тонет";
        }
    }
}
