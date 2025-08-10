using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Point3D
    {
        #region Day2
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public Point3D(double x, double y) : this(x, y, 0)
        {

        }
        public Point3D(double x) : this(x, 0, 0)
        {

        }
        public Point3D() : this(0, 0, 0)
        {

        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y || p1.Z != p2.Z;
        }

        public void Display()
        {
            Console.WriteLine($"X:{X},Y:{Y},Z:{Z}");
        }
        public void ChangeCoordinates(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        #endregion

        #region Day3
        public override string ToString()
        {
            return $"X:{X},Y:{Y},Z:{Z}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }

        public static void Display(params Point3D[] arr)
        {
            foreach(Point3D p in arr)
            {
                Console.WriteLine(p.ToString());
            }
        }
        #endregion
    }
}
