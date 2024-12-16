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
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;

                default:
                    Console.WriteLine("не верное число месяца");
                    break;
            }
        }
        /// <summary>
        /// Задача 3. По номеру месяца вывести название времени года.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            int a = Input("Введите число месяца: ");
            Week(a);
            Console.ReadLine();
        }
    }
}
