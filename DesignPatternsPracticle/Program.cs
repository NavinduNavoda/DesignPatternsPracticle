using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPracticle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingletonTest();
            //FactoryTest();
            //PizzaDecoratorTest();
            ShapeDecoratorTest();


            Console.ReadKey();
        }

        static void ShapeDecoratorTest() {
            Shape s = new RedShapeDecorator(new GreenShapeDecorator(new RectangleShape()));
            s.draw();
        }

        static void PizzaDecoratorTest() {
            Pizza pizza = new Mozzarella(new TomatoSauce(new PlainPizza()));
            Console.WriteLine(pizza.getDescription());
        }


        static void SingletonTest() {
            DBConnection conn1 = DBConnection.GetCurrInst();
            DBConnection conn2 = DBConnection.GetCurrInst();

            if (conn1 == conn2)
            {
                Console.WriteLine("same");
            } else {
                Console.WriteLine("diferent");
            }
        }

        static void FactoryTest() {
            ShapeFactory factory = new ShapeFactory();

            IShape rect = factory.getShape("rectangle");
            rect.draw();
        }
    }
}
