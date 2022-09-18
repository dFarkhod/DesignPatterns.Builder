using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class MilkTeaBuilder : TeaBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("#1 : Suv qaynatamiz");
            GetTea().Water = 80;
        }
        public override void SetTeaType()
        {
            Console.WriteLine("#2 : Qora choy qo'shamiz");
            GetTea().Name = "Sut choy";
        }
        public override void SetSugar()
        {
            Console.WriteLine("#3 : Shakar qo'shamiz");
            GetTea().Sugar = 10;
        }
        public override void SetLemon()
        {
            GetTea().Lemon = 0;
        }
        public override void SetMilk()
        {
            Console.WriteLine("#4 : Sut qo'shamiz");
            GetTea().Milk = 120;
        }
        public override void SetIce()
        {
            GetTea().Ice = 0;
        }
    }
}
