namespace DesignPatterns.NullObject
{
    public class NullCustomer : AbstractCustomer
    {
        public override string Name => "Not found in the database.";

        public override bool IsNull() => true;
    }
}
