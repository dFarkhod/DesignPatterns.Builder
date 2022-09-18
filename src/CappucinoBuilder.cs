using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class CappucinoBuilder : CoffeeBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("# 1 : Suv qaynatamiz");
            GetCoffee().Water = 40;
        }
        public override void SetMilk()
        {
            Console.WriteLine("# 2 : Sut qo'shamiz");
            GetCoffee().Milk = 50;
        }
        public override void SetSugar()
        {
            Console.WriteLine("# 3 : Shakar qo'shamiz");
            GetCoffee().Sugar = 10;
        }

        public override void SetChocolate()
        {
            GetCoffee().Chocolate = 0;
        }
        public override void SetEspresso()
        {
            Console.WriteLine("# 4 : Espresso qo'shamiz");
            GetCoffee().Espresso = 15;
        }
        public override void SetCoffeeType()
        {
            Console.WriteLine("Cappucino");
            GetCoffee().Name = "Cappucino";
        }
    }
}
