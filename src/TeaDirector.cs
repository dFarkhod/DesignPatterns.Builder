using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class TeaDirector
    {
        public Tea MakeTea(TeaBuilder teaBuilder)
        {
            teaBuilder.CreateTea();
            teaBuilder.SetWater();
            teaBuilder.SetTeaType();
            teaBuilder.SetMilk();
            teaBuilder.SetSugar();
            teaBuilder.SetLemon();
            teaBuilder.SetIce();

            return teaBuilder.GetTea();
        }
    }
}
