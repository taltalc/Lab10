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
            Triangle triangle = new Triangle(120,30, 12);
            triangle.ToRadians();
            Console.ReadKey();
        }

    }
    //Мы допускаем, что класс Triangle для  геометрических, а не для тригонометрических объектов.
    class Triangle 
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value >=0 )
                {
                    gradus = value;
                }
                else
                {
                   
                    Console.WriteLine("Введено некорректное значение градусов.");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >=0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение минут.");
                }
                min = value % 60;
                gradus += value / 60;

            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >=0)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение секунд.");
                }
                sec = value % 60;
                min += value / 60;
            }
            get
            {
                return sec;
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
            
            if (gradus>=0&& min >= 0 && sec >= 0 )
            {
              radians = (Math.PI * gradus + ((min + sec) / 60) / 60) / 180;
              Console.WriteLine("Заданный угол в радианах равен {0:f2}", radians);
                
            }
            else
            { 
                Console.WriteLine("Epic fail."); 
            }

        }
    }
}
