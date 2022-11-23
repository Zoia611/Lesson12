using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle
    {
        static public double GetLong(double r)
        {
            return r * 2 * Math.PI;
        }
        static public double GetSquare(double r)
        {
            return r * r * Math.PI;
        }
        static public string GetCor(double r, double x, double y, double x0 = 0, double y0 = 0)
        {
            if (Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2) <= (r * r))
            {
                return "принадлежит кругу";
            }
            else
            {
                return "не принадлежит кругу";
            }
        }
    }
}
