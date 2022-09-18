using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class CoffeeDirector
    {
        public Coffee MakeCoffee(CoffeeBuilder coffeeBuilder)
        {
            coffeeBuilder.CreateCoffee();
            coffeeBuilder.SetCoffeeType();
            coffeeBuilder.SetWater();
            coffeeBuilder.SetMilk();
            coffeeBuilder.SetSugar();
            coffeeBuilder.SetEspresso();

            return coffeeBuilder.GetCoffee();
        }
    }
}
