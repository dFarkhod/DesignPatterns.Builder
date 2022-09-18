using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class FluentCappucinoBuilder : FluentCoffeeBuilder
    {
        public override IFluentCoffeeBuilder SetWater()
        {
            Console.WriteLine("# 1 : Suv qaynatamiz");
            GetCoffee().Water = 40;
            return this;
        }
        public override IFluentCoffeeBuilder SetMilk()
        {
            Console.WriteLine("# 2 : Sut qo'shamiz");
            GetCoffee().Milk = 50;
            return this;
        }
        public override IFluentCoffeeBuilder SetSugar()
        {
            Console.WriteLine("# 3 : Shakar qo'shamiz");
            GetCoffee().Sugar = 10;
            return this;
        }
        public override IFluentCoffeeBuilder SetChocolate()
        {
            GetCoffee().Chocolate = 0;
            return this;
        }
        public override IFluentCoffeeBuilder SetEspresso()
        {
            Console.WriteLine("# 4 : Espresso qo'shamiz");
            GetCoffee().Espresso = 15;
            return this;
        }

        public override IFluentCoffeeBuilder SetCoffeeType()
        {
            Console.WriteLine("Cappucino");
            GetCoffee().Name = "Cappucino";
            return this;
        }

    }
}
