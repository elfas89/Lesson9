using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class MenuClass
    {
        private BankAccount[] accountsArray;

        public void Show()
        {
            //accountsArray = new BankAccount[3];
            //accountsArray[0] = new DepoAccount(555.5, "В.И.Депозитов",23.1);
            //accountsArray[1] = new CardAccount(777.7, "В.И.Карточкин", 0.0);
            //accountsArray[2] = new CurrAccount(10000.0, "В.И.Текущев");

            double balance = 0.0;
            string owner;
            BankAccount account = null;

            //foreach (var account in accountsArray)
            //{
            //    Console.WriteLine("Владелец счета " + account.GetOwner());
            //}


            Console.Clear();
            Console.WriteLine("Введите ФИО владельца счета:");
            owner = Console.ReadLine();

            while (balance == 0.0)
            {
                Console.Clear();
                Console.WriteLine("Введите баланс счета:");
                try
                {
                    double startBalance = Convert.ToDouble(Console.ReadLine());
                    if ((int)startBalance == 0)
                    {
                        return;
                    }
                    balance = startBalance;

                }
                catch (Exception)
                {
                    Console.WriteLine("Неверное число");
                    Console.ReadLine();
                }

            }



            while (true)
            {
                Console.Clear();
                Console.WriteLine("Доступные действия: ");
                Console.WriteLine("1 - Открыть депозитный счет");
                Console.WriteLine("2 - Открыть карточный счет");
                Console.WriteLine("3 - Открыть текущий счет");
                Console.WriteLine("0 - Выйти из программы");
                Console.Write("Введите номер: ");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        return;
                    }
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Выбран депозитный счет");
                            account = new DepoAccount(balance, owner);
                            break;
                        case 2:
                            Console.WriteLine("Выбран карточный счет");
                            account = new CardAccount(balance, owner);
                            break;
                        case 3:
                            Console.WriteLine("Выбран текущий счет");
                            account = new CurrAccount (balance, owner);
                            break;
                    }
                   // Console.WriteLine(account.GetOwner());
                   // return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный номер");
                    Console.ReadLine();
                }

                Options(account);

            }



        }


        private void Options(BankAccount account)
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Операции для счета клиента " + account.GetOwner());
                if (account is IRateOperations)
                {
                    Console.WriteLine("newrate - задать новую процентную ставку");
                    Console.WriteLine("plusrate - начислить проценты");
                }
                if (account is ICurrOperations)
                {
                    Console.WriteLine("moneyadd - положить деньги на счет");
                    Console.WriteLine("moneyget - снять деньги со счета");
                }
                Console.WriteLine("close - закрыть счет");
                Console.WriteLine("i - инфа по счету");
                Console.WriteLine("b - открыть другой тип счета");
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();
                Console.Clear();
                switch (command)
                {
                    case "newrate":
                        if (account is IRateOperations)
                        {
                            Console.WriteLine("Введите новую процентную ставку");
                            string rate = Console.ReadLine();
                            ((IRateOperations)account).RateSet(Convert.ToDouble(rate));
                        }
                        break;
                    case "plusrate":
                        if (account is IRateOperations)
                        {
                            ((IRateOperations)account).RatePlus();
                            Console.Clear();
                            Console.WriteLine(account.GetBalance());
                            Console.ReadKey();
                        }
                        break;
                    case "moneyadd":
                        if (account is ICurrOperations)
                        {
                            Console.WriteLine("Введите cумму, которую необходимо положить на счет");
                            string amount = Console.ReadLine();
                            ((ICurrOperations)account).CurrAdd(Convert.ToDouble(amount));
                            Console.WriteLine(account.GetBalance());
                            Console.ReadKey();
                        }
                        break;
                    case "moneyget":
                        if (account is ICurrOperations)
                        {
                            Console.WriteLine("Введите cумму, которую необходимо снять со счета");
                            string amount = Console.ReadLine();
                            ((ICurrOperations)account).CurrDiv(Convert.ToDouble(amount));
                            Console.WriteLine(account.GetBalance());
                            Console.ReadKey();
                        }
                        break;
                    case "b":
                        return;
                    case "i":
                        Console.WriteLine(account.GetOwner());
                        Console.WriteLine(account.GetBalance());
                        Console.ReadKey();
                        break;
                    case "close":
                        account.Close();
                        Console.WriteLine(account.GetBalance());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;

                }
               
            }
        }


    }
}
