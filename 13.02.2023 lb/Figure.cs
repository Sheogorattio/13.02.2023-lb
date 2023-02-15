using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClass
{
    abstract public class Figure
    {
        abstract public double Area();

    }
    public class Rectangle : Figure
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public Rectangle(double side_a, double side_b)
        {
            Side_A = side_a;
            Side_B = side_b;
        }
        public override double Area()
        {
            return Side_A * Side_B;
        }
    }

    public class Right_tirangle : Figure
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public Right_tirangle(double side_A, double side_B)
        {
            Side_A=side_A;
            Side_B = side_B;
        }
        public override double Area()
        {
            return Side_A * Side_B / 2;
        }
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
        static double pi = 3.14;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return pi*Math.Pow(Radius, 2);
        }
    }

    public class Trapez : Figure
    {
        public double Side_A { get; set; }
        public double Side_B { get; set; }
        public double H { get; set; }
        public Trapez(double side_A, double side_B, double h)
        {
            Side_A = side_A;
            Side_B = side_B;
            H = h;
        }

        public override double Area()
        {
            return (Side_A+Side_B)*H/2;
        }
    }
}
