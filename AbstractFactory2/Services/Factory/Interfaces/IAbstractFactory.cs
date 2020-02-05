using AbstractFactory2.Services.Interfaces;

namespace AbstractFactory2.Services.Factory.Interfaces
{
    public interface IAbstractFactory
    {
        IShape getRectangle();
        IShape getSquare();
    }
}
