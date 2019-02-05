using DesignPatterns.Abstract_Factory.Factories;

namespace DesignPatterns.Abstract_Factory
{
    class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool rounded) 
            => rounded ? (AbstractFactory) new RoundedShapeFactory() : new ShapeFactory();
    }
}
