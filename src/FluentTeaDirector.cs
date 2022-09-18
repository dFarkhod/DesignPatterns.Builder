using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class FluentTeaDirector
    {
        public Tea MakeTea(FluentTeaBuilder teaBuilder)
        {
            return teaBuilder
                        .CreateTea()
                        .SetWater()
                        .SetTeaType()
                        .SetMilk()
                        .SetSugar()
                        .SetLemon()
                        .SetMilk()
                        .SetIce()
                        .GetTea();
        }
    }
}
