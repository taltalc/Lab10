using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(120, 30, 12);
            triangle.ToRadians();
            Console.ReadKey();
        }

    }
    class Triangle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value > 0 && value % 1 == 0)
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение градусов.");
                }
            }
        }
        public int Min
        {
            set
            {
                if (value > 0 && value % 1 == 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение минут.");
                }
            }
        }
        public int Sec
        {
            set
            {
                if (value > 0 && value % 1 == 0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение секунд.");
                }
            }
        }
        public Triangle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;

        }
        public void ToRadians()
        {
            double radians = 0;
            radians = (Math.PI * gradus + ((min + sec) / 60) / 60) / 180;
            Console.WriteLine("Заданный угол в радианах равен {0:f2}", radians);
        }
    }
}
