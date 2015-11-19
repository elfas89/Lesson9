using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Fridge : TVset, ISwitchable
    {
        //private bool power;
        //private string name;
        //public bool Power { get; set; }
        //public string Name { get; set; }

        public Fridge (string name) : base (name)
        {
            Power = true;
            Name = name;
        }

        public override void Info()
        {
            Console.WriteLine("Холодильник включен: " + Power);
        }

    }
}
