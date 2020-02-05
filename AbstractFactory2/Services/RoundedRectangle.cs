﻿using AbstractFactory2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2.Services
{
    public class RoundedRectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Rounded Rectangle");
        }
    }
}
