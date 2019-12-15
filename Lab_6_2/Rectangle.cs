using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Lab_6_2
{
    public class Rectangle : Figure
    {
        public Rectangle(double propA, double propB)
        {
            PropA = propA;
            PropB = propB;
            Type = "Прямоугольник";
        }
        public Rectangle()
        {
            Type = "Прямоугольник";
        }
        public double PropA { get; set; }
        public double PropB { get; set; }
        public override double Area()
        {
            return PropA * PropB;
        }
        public int example(int x, int y)
        {
            return (x + y);
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        
    }
}
