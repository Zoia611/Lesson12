using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса, координаты точки (x,y), а также координаты центра окружности(x0,y0)");
            double r = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());

            double longCircle = Circle.GetLong(r);
            double square = Circle.GetSquare(r);
            string conf = Circle.GetCor(r, x, y, x0, y0);

            Console.WriteLine($"Длина окружности: {longCircle:f2}\nПлощадь круга: {square:f2}\nПринадлженость точки: {conf}");
            Console.ReadLine();
        }
    }
}
