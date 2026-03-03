using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            try
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;

                if (sideA <= 0 || SideB <= 0 || SideC <= 0) 
                { 
                    throw new ArgumentException("Ошибка: Введена отрицательная сторона"); 
                }

                TriangleChecker();
            }
            catch
            {
                throw new ArgumentException("Ошибка: Допустимы только числа");
            }
        }
        public void TriangleChecker()
        {
            if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            {
                throw new ArgumentException("Ошибка: треугольник не формируется");
            }
        }

        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override string ToString()
        {
            return $"Сторона A: {sideA}\nСторона B: {sideB}\nСторона C: {sideC}";
        }

    }
}
