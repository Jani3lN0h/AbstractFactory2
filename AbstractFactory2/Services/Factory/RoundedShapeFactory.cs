using AbstractFactory2.Services.Factory.Interfaces;
using AbstractFactory2.Services.Interfaces;

namespace AbstractFactory2.Services.Factory
{
    public class RoundedShapeFactory : IAbstractFactory
    {
        public IShape getRectangle()
        {
            return new RoundedRectangle();
        }

        public IShape getSquare()
        {
            return new RoundedSquare();
        }
    }
}
