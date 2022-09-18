using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public abstract class FluentCoffeeBuilder : IFluentCoffeeBuilder
    {
        protected Coffee coffe = null;
        public IFluentCoffeeBuilder CreateCoffee()
        {
            coffe = new Coffee();
            return this;
        }
        public abstract IFluentCoffeeBuilder SetWater();
        public abstract IFluentCoffeeBuilder SetMilk();
        public abstract IFluentCoffeeBuilder SetSugar();
        public abstract IFluentCoffeeBuilder SetEspresso();
        public abstract IFluentCoffeeBuilder SetChocolate();
        public abstract IFluentCoffeeBuilder SetCoffeeType();
        public Coffee GetCoffee()
        {
            return coffe;
        }
    }
}
