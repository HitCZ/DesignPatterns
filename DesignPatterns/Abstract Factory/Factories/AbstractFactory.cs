using DesignPatterns.Abstract_Factory.Enums;
using DesignPatterns.Abstract_Factory.Shapes;

namespace DesignPatterns.Abstract_Factory.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(ShapeType shapeType);
    }
}
