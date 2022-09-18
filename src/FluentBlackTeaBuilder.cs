using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class FluentBlackTeaBuilder : FluentTeaBuilder
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
            GetTea().Name = "Qora choy";
            return this;
        }
        public override IFluentTeaBuilder SetSugar()
        {
            GetTea().Sugar = 0;
            return this;
        }
        public override IFluentTeaBuilder SetLemon()
        {
            GetTea().Lemon = 00;
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
