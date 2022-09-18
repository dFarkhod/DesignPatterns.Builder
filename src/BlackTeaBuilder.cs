using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class BlackTeaBuilder : TeaBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("#1 : Suv qaynatamiz");
            GetTea().Water = 200;
        }
        public override void SetTeaType()
        {
            Console.WriteLine("#2 : Qora choy qo'shamiz");
            GetTea().Name = "Qora choy";
        }
        public override void SetMilk()
        {
            GetTea().Milk = 0;
        }
        public override void SetSugar()
        {
            GetTea().Sugar = 0;
        }
        public override void SetLemon()
        {
            GetTea().Lemon = 0;
        }
        public override void SetIce()
        {
            GetTea().Ice = 0;
        }

    }
}
