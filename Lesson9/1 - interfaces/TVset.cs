using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class TVset : ISwitchable
    {
        private bool power;
        private string name;
        public bool Power { get; set; }
        public string Name { get; set; }

        public TVset(string name)
        {
            Power = true;
            Name = name;
        }

        public void PowerOn()
        {
                Power = true;
        }
        public void PowerOff()
        {
                Power = false;
        }
        public virtual void Info()
        {
            Console.WriteLine("Телевизор включен: " + Power);
        }

    }
}
