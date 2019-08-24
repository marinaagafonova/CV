using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3DFunctionBL
{
    public class PolyLine3D
    {
        private List<Vector> vertices = new List<Vector>();
        public Pen ColorL { get; set; }

        public PolyLine3D()
        {
            ColorL = new Pen(Color.Black);
        }
        public PolyLine3D(IList<Vector> v, bool closed = false)
        {
            vertices.AddRange(v);
            if (closed)
                vertices.Add(v[0]);
        }
        public PolyLine3D(IList<Vector> v, Color color, bool closed = false)
        {
            vertices.AddRange(v);
            if (closed)
                vertices.Add(v[0]);
            ColorL = new Pen(color);
        }
        public List<Vector> Vertices
        {
            get { return vertices; }
        }
    }
}
