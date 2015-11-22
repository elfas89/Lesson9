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
        //    //1
        //    TVset sony = new TVset("Телек");
        //    sony.PowerOff();
        //    //Console.WriteLine(sony.Power);
        //    sony.Info();

        //    Fridge zanussi = new Fridge("Холодос");
        //    zanussi.Info();


        //    //
        //    Console.WriteLine("0 - телевизор, 1 - холодильник");

        //    char key = Console.ReadKey().KeyChar;
        //    ISwitchable device = null;

        //        switch (key)
        //        {
        //            case '0':
        //                Console.WriteLine("Выбран телевизор");
        //                device = sony;
        //                break;
        //            case '1':
        //                Console.WriteLine("Выбран холодильник");
        //                device = zanussi;
        //                break;
        //            default:
        //                Console.WriteLine("Введите 0 или 1");
        //                break;
        //        }

        //    //Console.Clear();
        //    Console.WriteLine("0 - выключить, 1 - включить");
        //    char k = Console.ReadKey().KeyChar;
        //    if (k != 0 || k != 1)
        //    {
        //        Console.WriteLine("Введите 0 или 1");
        //    }
                    

        //    CommonMethod(device, k);

        //}

        //static void CommonMethod(ISwitchable device, int x)
        //{
        //    if (x == 0)
        //    {
        //    device.PowerOff();
        //    device.Info();
        //    }
        //    else
        //    {
        //        device.PowerOn();
        //        device.Info();
        //    }


            //2
            //BankAccount mainAccount = new BankAccount(88.8, "Василий Иваныч");
            //Console.WriteLine(mainAccount.GetOwner());
            //Console.WriteLine(mainAccount.GetBalance());
            //Console.WriteLine(mainAccount.Close());
            //Console.WriteLine(mainAccount.GetBalance());

            //Console.WriteLine("\n");
            //DepoAccount depoAccount = new DepoAccount(555.5, "В.И.Депозитов");
            //Console.WriteLine(depoAccount.GetOwner());
            //Console.WriteLine(depoAccount.GetBalance());
            ////Console.WriteLine(depoAccount.Close());
            ////Console.WriteLine(depoAccount.GetBalance());
            //depoAccount.RateSet(50.0);
            //Console.WriteLine(depoAccount.Rate);
            //depoAccount.RatePlus();
            //Console.WriteLine(depoAccount.GetBalance());

            //Console.WriteLine("\n");
            //CardAccount cardAccount = new CardAccount(777.7, "В.И.Карточкин");
            //Console.WriteLine(cardAccount.GetOwner());
            //Console.WriteLine(cardAccount.GetBalance());
            //cardAccount.RateSet(100.0);
            //Console.WriteLine(cardAccount.Rate);
            //cardAccount.RatePlus();
            //Console.WriteLine(cardAccount.GetBalance());
            //cardAccount.CurrAdd(1000.0);
            //Console.WriteLine(cardAccount.GetBalance());
            //cardAccount.CurrDiv(2000.0);
            //Console.WriteLine(cardAccount.GetBalance());

            //Console.WriteLine("\n");
            //CurrAccount currAccount = new CurrAccount(10000.0, "В.И.Текущев");
            //Console.WriteLine(currAccount.GetOwner());
            //Console.WriteLine(currAccount.GetBalance());
            //currAccount.CurrAdd(2200.0);
            //Console.WriteLine(currAccount.GetBalance());
            //currAccount.CurrDiv(12196.0);
            //Console.WriteLine(currAccount.GetBalance());
            //currAccount.Close();
            //Console.WriteLine(currAccount.GetBalance());


            //2.1
            new MenuClass().Show();

        }
    }
}
