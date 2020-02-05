using AbstractFactory2.Services.Factory;
using AbstractFactory2.Services.Factory.Interfaces;
using System;

namespace AbstractFactory2.Services
{
    public class FactoryProducer
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************ Mostrar SHAPE ************");
            Console.ResetColor();
            ClientMethod(new ShapeFactory());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************ Mostrar ROUNDED SHAPE ************");
            Console.ResetColor();
            ClientMethod(new RoundedShapeFactory());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nPresione una tecla para salir.");
            Console.ReadKey();

        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var rectangle = factory.getRectangle();
            var square = factory.getSquare();

            rectangle.draw();
            square.draw();
        }
    }
}
