using DesignPatterns.Abstract_Factory.Enums;
using DesignPatterns.Abstract_Factory.Shapes;

namespace DesignPatterns.Abstract_Factory.Factories
{
    class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Square:
                    return new Rectangle();
            }

            return null;
        }
    }
}
