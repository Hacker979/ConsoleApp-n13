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
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("не верное число недели");
                    break;
            }
        }
        /// <summary>
        /// Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7.
        /// По указанному номеру n вывести название соответствующего дня недели.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            int a = Input("Введите число недели: ");
            Week(a);
            Console.ReadLine();
        }
    }
}
