using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n13
{
    class Program
    {
        static string Input(string a)
        {
            Console.Write(a);
            return Console.ReadLine();
        }

        static void Week(string a)
        {
            switch (a)
            {
                case "ф":
                    Console.WriteLine("физика");
                    break;
                case "м":

                    Console.WriteLine("математика");
                    break;
                case "и":

                    Console.WriteLine("история");
                    break;
                case "г":

                    Console.WriteLine("география");
                    break;
                case "б":
                    Console.WriteLine("биология");
                    break;

                default:
                    Console.WriteLine("не верная буква");
                    break;
            }
        }
        /// <summary>
        /// Задача 2. По номеру месяца вывести его название.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            string a = Input("Введите букву предмета: ");
            Week(a);
            Console.ReadLine();
        }
    }
}
