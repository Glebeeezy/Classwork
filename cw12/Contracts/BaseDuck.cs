namespace cw12.Contracts
{
    internal abstract class BaseDuck
    {
        public abstract string DuckType { get;  }
        public abstract string Swim();
        
        public virtual string Fly()
        {
            return "Летает";
        }
    }
}
