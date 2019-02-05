using DesignPatterns.Abstract_Factory.Enums;
using DesignPatterns.Abstract_Factory.Shapes;

namespace DesignPatterns.Abstract_Factory.Factories
{
    class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeType shapeType)
        {
            switch (shapeType)  
            {
                case ShapeType.Rectangle:
                    return new RoundedRectangle();
                case ShapeType.Square:
                    return new RoundedSquare();
            }

            return null;
        }
    }
}
