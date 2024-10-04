using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPracticle
{
    interface Shape {
        void draw();
    }

    class RectangleShape : Shape {
        public void draw() {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    class CircleShape : Shape
    {
        public void draw()
        {
            Console.WriteLine("Deawing Circle");
        }
    }

    class ShapeDecorator : Shape {
        private Shape temp;
        public ShapeDecorator(Shape temp) {
            this.temp = temp;
        }
 
        public virtual void draw() {
            temp.draw();
        }
    }

    class RedShapeDecorator: ShapeDecorator
    {
        public RedShapeDecorator(Shape temp) : base(temp) { }

        public override void draw() {
            setRedBorder();
            base.draw();
        }
        private void setRedBorder() {
            Console.WriteLine("Border Color: Red");
        }
    }

    class GreenShapeDecorator : ShapeDecorator
    {
        public GreenShapeDecorator(Shape temp) : base(temp) { }

        public override void draw()
        {
            setGreenBorder();
            base.draw();
        }
        public void setGreenBorder()
        {
            Console.WriteLine("Border Color: Green");
        }
    }

}
