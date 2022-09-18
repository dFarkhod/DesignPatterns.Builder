using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public abstract class FluentTeaBuilder : IFluentTeaBuilder
    {
        protected Tea tea = null;
        public IFluentTeaBuilder CreateTea()
        {
            tea = new Tea();
            return this;
        }
        public abstract IFluentTeaBuilder SetTeaType();
        public abstract IFluentTeaBuilder SetWater();
        public abstract IFluentTeaBuilder SetMilk();
        public abstract IFluentTeaBuilder SetSugar();
        public abstract IFluentTeaBuilder SetLemon();
        public abstract IFluentTeaBuilder SetIce();
        public Tea GetTea()
        {
            return tea;
        }
    }
}
