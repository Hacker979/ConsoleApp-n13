using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n13
{
    class Program
    {
        static int Input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }

        static void Week(int a)
        {
            switch (a)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;

                default:
                    Console.WriteLine("не верное число месяца");
                    break;
            }
        }
        /// <summary>
        /// Задача 2. По номеру месяца вывести его название.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            int a = Input("Введите число месяца : ");
            Week(a);
            Console.ReadLine();
        }
    }
}
