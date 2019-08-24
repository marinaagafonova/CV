using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFunctionBL
{
    public class Camera
    {
        public Matrix View { get; set; }
        public Matrix Projectiom { get; set; }
        public Camera()
        {
            View = Matrix.One();
            Projectiom = Matrix.One();
        }
        public Vector Convert(Vector v)
        {
            Vector r = Projectiom * View * new Vector(v);
            return new Vector(r);
        }
    }
}
