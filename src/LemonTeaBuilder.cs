using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class LemonTeaBuilder : TeaBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("#1 : Suv qaynatamiz");
            GetTea().Water = 200;
        }
        public override void SetTeaType()
        {
            Console.WriteLine("#2 : Qora choy qo'shamiz");
            GetTea().Name = "Limon choy";
        }
        public override void SetSugar()
        {
            Console.WriteLine("#3 : Shakar qo'shamiz");
            GetTea().Sugar = 10;
        }
        public override void SetLemon()
        {
            Console.WriteLine("#4 : Limon qo'shamiz");
            GetTea().Lemon = 20;
        }
        public override void SetMilk()
        {
            GetTea().Milk = 0;
        }
        public override void SetIce()
        {
            GetTea().Ice = 0;
        }
    }
}
