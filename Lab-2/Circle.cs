using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Circle : Figure, IPrint
    {
        public Circle(double propR)
        {
            PropR = propR;
            Type = "Круг";
        }
        public Circle()
        {
            Type = "Круг";
        }
        public double PropR { get; set; }
        public override double Area()
        {
            return Math.PI * PropR * PropR;
        }
        
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
