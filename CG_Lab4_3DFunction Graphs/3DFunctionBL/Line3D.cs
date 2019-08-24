using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3DFunctionBL
{
    public class Line3D : IModel
    {
        Vector v1, v2;
        public Pen ColorL { get; set; }
        public Line3D(Vector a, Vector b)
        {
            v1 = a;
            v2 = b;
        }
        public Line3D(Vector a, Vector b, Color color)
        {
            v1 = a;
            v2 = b;
            ColorL = new Pen(color);
        }
        public List<PolyLine3D> GetLines()
        {
            return new List<PolyLine3D>() { new PolyLine3D(new List<Vector>() { v1, v2}, ColorL.Color)
            };
        }
    }
}
