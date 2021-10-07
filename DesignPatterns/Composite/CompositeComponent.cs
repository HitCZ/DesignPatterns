using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite
{
    public class CompositeComponent : IComponent
    {
        #region Properties

        public ICollection<IComponent> Components { get; } = new List<IComponent>();

        #endregion Properties

        #region Public Methods

        public int GetPrice() => Components.Select(c => c.GetPrice()).Sum();

        #endregion Public Methods
    }
}
