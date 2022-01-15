using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "Введите радиус окружности = ";
            double R = Math.Abs(input(Text));
            Text = "Введите координату X центра окружности = ";
            double X0 = input(Text);
            Text = "Введите координату Y центра окружности = ";
            double Y0 = input(Text);
            Text = "Введите координату X точки x,y = ";
            double X = input(Text);
            Text = "Введите координату Y точки x,y = ";
            double Y = input(Text);
            Console.WriteLine();
            Console.WriteLine("Длина окружности с радиусом {0} равна {1}", R, Circle.CircleLength(R));
            Console.WriteLine("Площадь окружности с радиусом {0} равна {1}", R, Circle.CircleSquare(R));
            Circle.CirclePoint(X, Y, R, X0, Y0);
            Circle.CirclePoint(X, Y, R);        // для проверки значений поумолчанию
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        static double input(string Text)
        {
            double N = 0;
            Console.Write(Text);
            try
            {
                N = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Неверный ввод");
                N = input(Text);
            }
            return N;
        }

        class Circle
        {
            public static double CircleLength(double radius)
            {
                double Length = 2 * Math.PI * radius;
                return Length;
            }
            public static double CircleSquare(double radius)
            {
                double Square = Math.PI * radius * radius;
                return Square;
            }
            public static void CirclePoint(double x, double y, double radius, double x0 = 0, double y0 = 0)
            {
                double Length = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
                if (Length > radius)
                {
                    Console.WriteLine("Точка с координатами ({0}; {1}) НЕ входит в окружность с радиусом {2} и центром ({3};{4})", x, y, radius, x0, y0);
                }
                else
                {
                    if (Length == radius)
                    {
                        Console.WriteLine("Точка с координатами ({0}; {1}) лежит на окружности с радиусом {2} и центром ({3};{4})", x, y, radius, x0, y0);
                    }
                    else
                    {
                        Console.WriteLine("Точка с координатами ({0}; {1}) ВХОДИТ в окружность с радиусом {2} и центром ({3};{4})", x, y, radius, x0, y0);
                    }
                }
            }


        }
    }
}