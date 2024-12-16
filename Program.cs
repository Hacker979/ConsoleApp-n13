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
                case "а":
                    Console.WriteLine("автомобиль 800км/ч");
                    break;
                case "в":

                    Console.WriteLine("велосипед 40км/ч");
                    break;
                case "м":

                    Console.WriteLine("мотоцикл 300км/ч");
                    break;
                case "с":

                    Console.WriteLine("самолет 1000км/ч");
                    break;
                case "п":
                    Console.WriteLine("поезд 300км/ч");
                    break;

                default:
                    Console.WriteLine("не верная буква");
                    break;
            }
        }
        /// <summary>
        /// Задача 5. Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            string a = Input("Введите букву транспорта: ");
            Week(a);
            Console.ReadLine();
        }
    }
}
