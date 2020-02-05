using AbstractFactory2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProducer factory = new FactoryProducer();
            factory.Main();
        }
    }
}
