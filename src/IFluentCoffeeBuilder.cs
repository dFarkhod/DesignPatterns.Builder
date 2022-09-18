using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public interface IFluentCoffeeBuilder
    {
        IFluentCoffeeBuilder CreateCoffee();
        IFluentCoffeeBuilder SetCoffeeType();
        IFluentCoffeeBuilder SetWater();
        IFluentCoffeeBuilder SetMilk();
        IFluentCoffeeBuilder SetSugar();
        IFluentCoffeeBuilder SetChocolate();
        IFluentCoffeeBuilder SetEspresso();
        Coffee GetCoffee();
    }
}
