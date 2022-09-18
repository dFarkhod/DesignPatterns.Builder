using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class Coffee
    {
        public string Name { get; set; }
        public double Water { get; set; }
        public double Milk { get; set; }
        public double Sugar { get; set; }
        public double Espresso { get; set; }
        public double Chocolate { get; set; }
        public double Ice { get; set; }
        public double Caramel { get; set; }
        public double Foam { get; set; }
        public double WhippedCream { get; set; }
        public double IceCream { get; set; }

        public string Show()
        {
            return $"{Name} tayyor bo'ldi!";
        }
    }
}
