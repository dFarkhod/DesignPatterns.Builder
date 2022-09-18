using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDars.DesignPatterns.Builder
{
    public class Tea
    {
        public string Name { get; set; }
        public double Water { get; set; }
        public double Milk { get; set; }
        public double Sugar { get; set; }
        public double Lemon { get; set; }
        public double Ice { get; set; }
        public string Type { get; set; }

        public string Show()
        {
            return $"{Name} tayyor bo'ldi!";
        }
    }
}
