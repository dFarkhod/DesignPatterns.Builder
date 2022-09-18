using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class FluentLemonTeaBuilder : FluentTeaBuilder
    {
        public override IFluentTeaBuilder SetWater()
        {
            Console.WriteLine("#1 : Suv qaynatamiz");
            GetTea().Water = 200;
            return this;
        }
        public override IFluentTeaBuilder SetTeaType()
        {
            Console.WriteLine("#2 : Qora choy qo'shamiz");
            GetTea().Name = "Limon choy";
            return this;
        }
        public override IFluentTeaBuilder SetSugar()
        {
            Console.WriteLine("#3 : Shakar qo'shamiz");
            GetTea().Sugar = 10;
            return this;
        }
        public override IFluentTeaBuilder SetLemon()
        {
            Console.WriteLine("#4 : Limon qo'shamiz");
            GetTea().Lemon = 20;
            return this;
        }
        public override IFluentTeaBuilder SetIce()
        {
            GetTea().Ice = 0;
            return this;
        }

        public override IFluentTeaBuilder SetMilk()
        {
            GetTea().Milk = 0;
            return this;
        }

    }
}
