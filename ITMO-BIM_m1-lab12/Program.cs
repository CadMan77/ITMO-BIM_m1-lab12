using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_BIM_m1_lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус, мм (положительное число > 0):");
            try
            {
                Circle.Rad = Convert.ToDouble(Console.ReadLine());
                if (Circle.Rad<=0)
                {
                    Console.WriteLine("Ошибка! Введено некорректное число.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Длина окружности \t~ {0:f2} мм.",Circle.Length(Circle.Rad));
                    Console.WriteLine("Площадь круга \t\t~ {0:f2} мм^2.", Circle.Square(Circle.Rad));
                    Console.WriteLine();
                    double X=0, Y=0;
                    try
                    {
                        Console.WriteLine("Укажите координаты точки для проверки ее принадлежности кругу:");
                        Console.WriteLine("Х:");
                        X = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Y:");
                        Y = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ошибка! Недопустимые символы при вводе координат точки.");
                        Console.ReadKey();
                    }
                    if (Circle.Belongs(Circle.Rad, X, Y))
                    {
                        Console.WriteLine("Точка принадлежит кругу.");
                    }
                    else
                    {
                        Console.WriteLine("Точка НЕ принадлежит кругу.");
                    }
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Ввод содержит недопустимые символы.");
                Console.ReadKey();
            }
        }
        static class Circle
        {
            static public double Rad;
            static public double Length(double R)  
            {
                double CLn = 2 * Math.PI * R;
                return CLn;
            }
            static public double Square(double R)
            {
                double CSq = Math.PI * R * R;
                return CSq;
            }
            static public bool Belongs(double R, double X, double Y)
            {
                double Dist = Math.Sqrt((X * X) + (Y * Y));
                if (Dist>R)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
