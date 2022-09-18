using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class FluentCoffeeDirector
    {
        public Coffee MakeCoffee(FluentCoffeeBuilder coffeeBuilder)
        {
            return coffeeBuilder
                        .CreateCoffee()
                        .SetCoffeeType()
                        .SetWater()
                        .SetMilk()
                        .SetSugar()
                        .SetChocolate()
                        .SetEspresso()
                        .GetCoffee();
        }
    }
}
