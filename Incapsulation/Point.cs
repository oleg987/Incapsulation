using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation
{
    class Point
    {
        // Поля
        string name;
        public int x;
        public int y;
        public int z;

        // Конструкторы класса

        // Конструктор без параметров. Создает экземпляр объекта.
        public Point()
        {
           
            // Поля инициализируются значениями по умолчанию, если не указано иного.
        }

        //Конструктор с параметрами. Создает экземпляр объекта и присваивает полям значения полученные из параметров
        public Point(int xx, int yy, int zz)
        {
            x = xx;
            y = yy;
            z = zz;
        }

        //// Методы

        //Расстояние между точками. Экземплярный метод.
        public double Distance(Point second)
        {
            return Math.Round(Math.Sqrt((x - second.x) * (x - second.x) +
                                        (y - second.y) * (y - second.y) +
                                        (z - second.z) * (z - second.z)), 2);
        }

        //Расстояние между точками. Статический метод. Метод класса.
        public static double Distance(Point first, Point second)
        {
            return Math.Round(Math.Sqrt((first.x - second.x) * (first.x - second.x) +
                                        (first.y - second.y) * (first.y - second.y) +
                                        (first.z - second.z) * (first.z - second.z)), 2);
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
