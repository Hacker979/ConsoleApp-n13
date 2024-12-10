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
        static int InputInt(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }

        static void Week(string a)
        {
            switch (a)
            {
                case "к":
                    Console.WriteLine("круг");
                    int r = InputInt("Введите радиус ");
                    double s = 3.14 * r * r;
                    double p = 2 * 3.14 * r;
                    Console.WriteLine($"площадь: {s}   Периметр: {p}");
                    break;

                case "п":
                    Console.WriteLine("прямоугольник");
                    int d1 = InputInt("Введите длину ");
                    int d2 = InputInt("Введите ширину ");
                    s = d1 * d2;
                    p = 2 * (d2 + d1);
                    Console.WriteLine($"площадь: {s}   Периметр: {p}");
                    break;

                case "т":
                    Console.WriteLine("треугольник");
                    d1 = InputInt("Введите стороны ");
                    d2 = InputInt("Введите высоту ");
                    s = (d1 * d2)/2;
                    p = d1*3;
                    Console.WriteLine($"площадь: {s}   Периметр: {p}");
                    break;

                default:
                    Console.WriteLine("не верная буква");
                    break;
            }
        }
        /// <summary>
        /// Задача 6. Дан признак геометрической фигуры на плоскости: к – круг, п – прямоугольник,
        /// т - треугольник. Вывести на экран периметр и площадь заданной фигуры 
        /// (данные, необходимые для расчетов, запросить у пользователя).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            string a = Input("Введите букву фигуры: ");
            Week(a);
            Console.ReadLine();
        }
    }
}
