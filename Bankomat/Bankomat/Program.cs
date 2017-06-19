using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using bs = BankSpace;
using cs = ClientSpace;
using ac = AccountSpace;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int rand = r.Next(3, 7);
            Console.WriteLine("\t\t\t**********Открываем счет**********");
            for (int i = 0; i < rand; i++)
            {
                Console.Write(" .");
                Thread.Sleep(1000);
            }

            //создание счета (получение номера и инициализация пароля)
            ac.Account acc = new ac.Account();
            cs.Client cl = new cs.Client();
            Console.WriteLine("\n\nНомер Вашего счета: " + acc.bankAccount + "\n");//номер счета

            //регистрация
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            cl.clientName = name;
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            cl.clienSurname = surname;
            Console.Write("Введите возраст: ");
            bool bAge; int iAge;
            string sAge = Console.ReadLine();
            bAge = Int32.TryParse(sAge, out iAge);
            if (!bAge)
            {
                Console.WriteLine("Ошибка формата");
            }
            else
            {
                cl.clientAge = iAge;
            }
            Console.WriteLine("\n");


            //работа с паролем
            int count = 3;
            bool f = true, flag = true;
            Console.Write("Введите Ваш пароль: ");
            string password = Console.ReadLine();

            while (f)
            {
                Console.Write("Повторите пароль: ");
                string password2 = Console.ReadLine();

                if (password2 != password)
                {
                    count--;
                    Console.WriteLine("Пароли не совпадают!");
                    if (count != 0)
                    {
                        continue;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    acc.bankPassword = password;
                    f = false;
                }
            }


            //работа с меню

            Console.WriteLine("Войдите в свою учетную запись\n");
            while (flag)
            {
                int passCount = 3;
            start:
                Console.Write("Введите пароль: ");
                string pass = Console.ReadLine();
                if (pass != acc.bankPassword)
                {
                    passCount--;
                    Console.WriteLine("Неверный пароль, попробуйте еще раз\n");
                    if (passCount != 0)
                    {
                        goto start;
                    }
                    else
                    {
                        Console.WriteLine("Вы 3 раза ввели неверный пароль, для восстановления пароля, пожалуйства обратитесь в службу поддержки\n");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Для полной активации карты необходимо внести сумму не меньше 100 у.е.");
                    bool bMon; int iMon;
                    string sMon = Console.ReadLine();
                    bMon = Int32.TryParse(sMon, out iMon);
                    if (!bMon)
                    {
                        Console.WriteLine("Ошибка формата");
                    }
                    else
                    {
                        cl.clientMoney = iMon;
                        cl.putMoney = true;


                        bool f2 = true;
                        while (f2)
                        {
                            Console.WriteLine("1 - Вывод баланса на экран\n2 - Пополнение счёта\n3 - Снять деньги со счета\n4 - Очистить экран\n5 - Выход");
                            string sChoice = Console.ReadLine();
                            int iChoice;
                            bool bChoice = Int32.TryParse(sChoice, out iChoice);

                            if (!bChoice)
                            {
                                Console.WriteLine("Ошибка формата");
                            }
                            else//меню
                            {
                                switch (iChoice)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Ваш баланс: " + cl.clientMoney + "$");
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.Write("Введите необходимую сумму для пополнения счета: ");
                                            string sSum = Console.ReadLine();
                                            int iPlus;
                                            bool bPlus = Int32.TryParse(sSum, out iPlus);
                                            if (!bPlus)
                                            {
                                                Console.WriteLine("Ошибка формата");
                                            }
                                            else
                                            {
                                                cl.clientMoney = cl.clientMoney + iPlus;
                                                Console.WriteLine("Ваш баланс: " + cl.clientMoney + "$");
                                            }
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.Write("Введите необходимую сумму для снятия со счета счета: ");
                                            string sMinus = Console.ReadLine();
                                            int iMinus;
                                            bool bMinus = Int32.TryParse(sMinus, out iMinus);
                                            if (!bMinus)
                                            {
                                                Console.WriteLine("Ошибка формата");
                                            }
                                            else
                                            {
                                                if (cl.clientMoney < iMinus)
                                                {
                                                    Console.WriteLine("У вас недостаточно средств\n\n");
                                                }
                                                else
                                                {
                                                    cl.clientMoney = cl.clientMoney - iMinus;
                                                    Console.WriteLine("Ваш баланс: " + cl.clientMoney + "$");
                                                }
                                            }
                                        }
                                        break;
                                    case 4:
                                        {
                                            Console.Clear();
                                        }break;
                                    case 5:
                                        {
                                            f2 = false;
                                            flag = false;
                                        }break;
                                    default:
                                        {
                                            Console.WriteLine("Такого варианта нет");
                                        }break;
                                }//конец switch
                            }
                        }//конец внутреннего while



                    }
                }
            }    //конец внешнего while







        }
    }
}
