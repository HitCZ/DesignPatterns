namespace DesignPatterns.Composite
{
    public class FinalComponent : IComponent
    {
        #region Fields

        private readonly int price;

        #endregion Fields

        #region Constructor

        public FinalComponent(int price)
        {
            this.price = price;
        }

        #endregion Constructor

        #region Public Methods

        public int GetPrice() => price;

        #endregion Public Methods
    }
}
