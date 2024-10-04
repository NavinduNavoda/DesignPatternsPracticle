using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPracticle
{
    abstract class Pizza
    {
        public abstract string getDescription();
        public abstract double getCost();
    }

    class PlainPizza : Pizza
    {
        public override string getDescription()
        {
            return "Thin dough";
        }

        public override double getCost()
        {
            return 4.00;
        }
    }

    abstract class ToppingsDecorator : Pizza { 
        private Pizza tempPizza;

        public ToppingsDecorator(Pizza newPizza) {
            tempPizza = newPizza;
        }

        public override string getDescription()
        {
            return tempPizza.getDescription();
        }

        public override double getCost()
        {
            return tempPizza.getCost();
        }
    }

    abstract class CheeseDecorator : ToppingsDecorator {
        public CheeseDecorator(Pizza newPizza) : base(newPizza) { }

        public override string getDescription()
        {
            return base.getDescription() + ", cheese";
        }

        public override double getCost()
        {
            return base.getCost() + 0.50;
        }
    }

    class Mozzarella : CheeseDecorator {
        public Mozzarella(Pizza newPizza) : base(newPizza) {
            Console.WriteLine("Adding mozzarella");
        }

        public override string getDescription()
        {
            return base.getDescription() + ", mozzarella";
        }

        public override double getCost()
        {
            return base.getCost() + 0.50;
        }
    }

    class TomatoSauce : ToppingsDecorator {
        public TomatoSauce(Pizza newPizza) : base(newPizza) {
            Console.WriteLine("Adding tomato sauce");
        }

        public override string getDescription()
        {
            return base.getDescription() + ", tomato sauce";
        }

        public override double getCost()
        {
            return base.getCost() + 0.35;
        }
    }
}
