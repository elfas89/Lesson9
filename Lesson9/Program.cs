using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            TVset sony = new TVset("Телек");
            sony.PowerOff();
            //Console.WriteLine(sony.Power);
            sony.Info();

            Fridge zanussi = new Fridge("Холодос");
            zanussi.Info();


            //
            Console.WriteLine("0 - телевизор, 1 - холодильник");


            char key = Console.ReadKey().KeyChar;
            ISwitchable device = null;

                switch (key)
                {
                    case '0':
                        Console.WriteLine("Выбран телевизор");
                        device = sony;
                        break;
                    case '1':
                        Console.WriteLine("Выбран холодильник");
                        device = zanussi;
                        break;
                    default:
                        Console.WriteLine("Введите 0 или 1");
                        break;
                }

            //Console.Clear();
            Console.WriteLine("0 - выключить, 1 - включить");
            char k = Console.ReadKey().KeyChar;
            if (k != 0 || k != 1)
            {
                Console.WriteLine("Введите 0 или 1");
            }
                    

            CommonMethod(device, k);

        }

        static void CommonMethod(ISwitchable device, int x)
        {
            if (x == 0)
            {
            device.PowerOff();
            device.Info();
            }
            else
            {
                device.PowerOn();
                device.Info();
            }

        }

    }
}
