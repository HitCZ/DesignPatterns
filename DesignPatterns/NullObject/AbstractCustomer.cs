namespace DesignPatterns.NullObject
{
    public abstract class AbstractCustomer
    {
        public virtual string Name { get; protected set; }

        public abstract bool IsNull();
    }
}
