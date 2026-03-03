using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public double Width { get;  set; }
        private double Height { get; set; }

        public Rectangle(double width, double height)
        {
            try
            {
                Width = width;
                Height = height;

                if (Height <= 0 || Width <= 0)
                    throw new ArgumentException("Ошибка: Введена отрицательная сторона");
            }
            catch 
            {
                throw new ArgumentException("Ошибка: Допустимы только числа");
            }
        }

        public override double Area()
        {
            return  Height * Width;
        }

        public override double Perimeter()
        {
            return 2*(Height + Width);
        }

        public override string ToString()
        {
            return $"Прямоугольник с параметрами: \n ширина = {Width}, высота = {Height}, площадь = {Area()}, периметр = {Perimeter()}"; ;
        }
    }
}
