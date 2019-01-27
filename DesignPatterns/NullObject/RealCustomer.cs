namespace DesignPatterns.NullObject
{
    public sealed class RealCustomer : AbstractCustomer {

        public RealCustomer(string name) {
            Name = name;
        }

        public override bool IsNull() {
            return false;
        }
    }
}
