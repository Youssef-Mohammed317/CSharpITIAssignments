using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Point : IComparable<Point> , ICloneable
    {
        public int X { get; set; }

        public override string ToString()
        {
            return $"X = {X}";
        }

        public object Clone()
        {
            return new Point() { X = this.X };
        }


        public int CompareTo(Point? other)
        {
            return X.CompareTo(other?.X);
        }
    }
}
