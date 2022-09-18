using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public interface ICoffeeBuilder
    {
        void CreateCoffee();
        void SetCoffeeType();
        void SetWater();
        void SetMilk();
        void SetSugar();
        void SetChocolate();
        void SetEspresso();
        Coffee GetCoffee();
    }
}
