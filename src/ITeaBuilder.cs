using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public interface ITeaBuilder
    {
        void CreateTea();
        void SetTeaType();
        void SetWater();
        void SetMilk();
        void SetSugar();
        void SetLemon();
        void SetIce();
        Tea GetTea();
    }
}
