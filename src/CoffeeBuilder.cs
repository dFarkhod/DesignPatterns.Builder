using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public abstract class CoffeeBuilder : ICoffeeBuilder
    {
        protected Coffee coffee;

        public void CreateCoffee()
        {
            coffee = new Coffee();
        }

        public abstract void SetCoffeeType();
        public abstract void SetWater();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetChocolate();
        public abstract void SetEspresso();
        public Coffee GetCoffee()
        {
            return coffee;
        }


    }
}
