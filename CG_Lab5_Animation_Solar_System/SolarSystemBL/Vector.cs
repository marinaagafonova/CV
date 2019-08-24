using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemBL
{
    public class Vector
    {
        double x, y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public float Length
        {
            get { return (float)Math.Sqrt(X * X + Y * Y); }
        }
        public Vector Normalize
        {
            get
            {
                float l = Length;
                return (l < 1e-15) ? this : new Vector(X / l, Y / l);
            }
        }
        public static Vector operator *(Vector c, float n)
        {
            return new Vector(c.X * n, c.Y * n);
        }
        public static Vector operator *(float n, Vector v)
        {
            return v * n;
        }
        public static Vector operator +(Vector c1, Vector c2)
        {
            return new Vector(c1.X + c2.X, c1.Y + c2.Y);
        }
        public static Vector operator -(Vector c1, Vector c2)
        {
            return new Vector(c1.X - c2.X, c1.Y - c2.Y);
        }
    }
}
