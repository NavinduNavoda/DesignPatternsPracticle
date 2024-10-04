using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPracticle
{
    internal class Factory
    {   
    }

    interface IShape {
        void draw();
    }

    class Circle : IShape {
        public void draw() {
            Console.WriteLine("Drawing circle");
        }
    }

    class Square : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing square");
        }
    }

    class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }


    class ShapeFactory
    {
        public IShape getShape(string shapeName) {
            switch (shapeName) {
                case "cicle":
                    return new Circle();
                case "square":
                    return new Square();
                case "rectangle":
                    return new Rectangle();
                default:
                    throw new Exception("invalid shapeName");
            }
        }
    }
}
