using AbstractFactory2.Services.Factory.Interfaces;
using AbstractFactory2.Services.Interfaces;

namespace AbstractFactory2.Services.Factory
{
    public class ShapeFactory : IAbstractFactory
    {
        public IShape getRectangle()
        {
            return new Rectangle();
        }

        public IShape getSquare()
        {
            return new Square();
        }
    }
}
