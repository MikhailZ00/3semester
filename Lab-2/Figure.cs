using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Figure : IComparable
    {
        abstract public double Area();
        public string Type { get; protected set; }

        public override string ToString() { return this.Type + " площадью " + this.Area().ToString(); }

        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.Area() < p.Area())
                return -1;
            else if (this.Area() == p.Area())
                return 0;
            else return 1;
        }
    }
}