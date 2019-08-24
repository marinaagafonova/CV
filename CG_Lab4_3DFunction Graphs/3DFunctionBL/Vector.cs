using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFunctionBL
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double W { get; set; }
        public Vector()
        {
            X = 0.0;
            Y = 0.0;
            Z = 0.0;
            W = 1.0;
        }
        public Vector(Vector v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = v.W;
        }
        public Vector(double X, double Y, double Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        public Vector(double X, double Y, double Z, double w)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.W = w;
        }
        
        public static Vector operator +(Vector a, Vector v)
        {
            return new Vector(a.X + v.X, a.Y + v.Y, a.Z + v.Z, a.W);
        }
        public static Vector operator -(Vector a, Vector v)
        {
            return new Vector(a.X - v.X, a.Y - v.Y, a.Z - v.Z, a.W);
        }
        public static double operator *(Vector a, Vector v)
        {
            return a.X * v.X + a.Y * v.Y + a.Z * v.Z;
        }
        public static Vector operator *(double c, Vector v)
        {
            return new Vector(c * v.X, c * v.Y, c * v.Z, v.W);
        }
        public static Vector operator ^(Vector a, Vector v)
        {
            Vector r = new Vector();
            r.X = a.Y * v.Z - a.Z * v.Y;
            r.Y = a.Z * v.X - a.X * v.Z;
            r.Z = a.X * v.Y - a.Y * v.X;
            r.W = a.W;
            return r;
        }
        public static Vector operator %(Vector a, Vector v)
        {
            Vector r = new Vector();
            r.X = a.X * v.X;
            r.Y = a.Y * v.Y;
            r.Z = a.Z * v.Z;
            r.W = a.W * v.W;
            return r;
        }
        public static Vector operator *(Vector a, double c)
        {
            return new Vector(c * a.X, c * a.Y, c * a.Z, a.W);
        }
        public static Vector operator /(Vector a, double c)
        {
            return new Vector(a.X / c, a.Y / c, a.Z / c, a.W);
        }
        public static Vector operator +(Vector v)
        {
            return v;
        }
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y, -v.Z, v.W);
        }
       
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", X, Y, Z, W);
        }
    }
}
