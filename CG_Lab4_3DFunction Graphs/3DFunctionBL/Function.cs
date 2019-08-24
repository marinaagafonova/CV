using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3DFunctionBL
{
    public class Function : IModel
    {
        public IFunction F { get; set; }

        public int[] Domain { get; set; }
        public double Split { get; set; }
        public Pen ColorL { get; set; }

        public Function(IFunction f)
        {
            F = f;
            if (Domain == null)
                Domain = new int[]{ -5, 5, -5, 5 };
            Split = 1;
       
        }
        public Function(IFunction f, Color color)
        {
            F = f;
            Domain = new int[] { -5, 5, -5, 5 };
            ColorL = new Pen(color);

        }
        public Function(IFunction f, int[] split)
        {
            F = f;
            Domain = new int[] { split[0], split[1], split[2], split[3] };
        }
        public Function(IFunction f, int[] split, Color color)
        {
            F = f;
            Domain = new int[] { split[0], split[1], split[2], split[3] };
            ColorL = new Pen(color);
        }
        public void UpdateParam(int[] split)
        {
            Domain = new int[] { split[0], split[1], split[2], split[3] };

        }
        public List<PolyLine3D> GetLines()
        {
            if (F == null)
                return new List<PolyLine3D>();
            const double h = 0.1;
            double x = 0, y = 0, i;
           // double split = 0.5; 
             List<PolyLine3D> r = new List<PolyLine3D>();
            for (i = Domain[0]; i <= Domain[1]; i += Split)
            {

                x = h * i;
                y = Domain[2];
                for (y = Domain[2]; y <= Domain[3]; y += Split)
                {

                    r.Add(new PolyLine3D(new List<Vector>()
                        {
                            new Vector(x, y*h, F.Compute(x, y*h)),
                            new Vector(h*(i+Split), y*h, F.Compute(h*(i+Split), y*h)),
                            new Vector(h*(i+Split), (y+Split)*h, F.Compute(h*(i+Split), (y+Split)*h)),
                            new Vector(x, (y+Split)*h, F.Compute(h*i, (y+Split)*h))
                        }, ColorL.Color, true));

                    //r.Add(new PolyLine3D(new List<Vector>()
                    //    {
                    //        new Vector(x, y*h, F.Compute(x, y*h)),
                    //        new Vector(h*(i+1)/2, y*h, F.Compute(h*(i+1)/2, y*h)),
                    //        new Vector(h*(i+1)/2, (y+1)*h/2, F.Compute(h*(i+1)/2, (y+1)*h/2)),
                    //        new Vector(x, (y+1)*h/2, F.Compute(h*i, (y+1)*h/2))
                    //    }, true));
                    //r.Add(new PolyLine3D(new List<Vector>()
                    //    {
                    //        new Vector(h*(i+1)/2, (y+1)*h/2, F.Compute(h*(i+1)/2, (y+1)*h/2)),
                    //        new Vector(h*(i+1), (y+1)*h/2, F.Compute(h*(i+1), (y+1)*h/2)),
                    //        new Vector(h*(i+1), (y+1)*h, F.Compute(h*(i+1), (y+1)*h)),
                    //        new Vector(h*(i+1)/2, (y+1)*h, F.Compute(h*(i+1)/2, (y+1)*h))
                    //    }, true));

                }
                if (Split < 1.0)
                    r.Add(new PolyLine3D(new List<Vector>()
                    {
                            new Vector(x, y*h, F.Compute(x, y*h)),
                            new Vector(h*(i+Split), y*h, F.Compute(h*(i+Split), y*h)),
                            new Vector(h*(i+Split), (y+Split)*h, F.Compute(h*(i+Split), (y+Split)*h)),
                            new Vector(x, (y+Split)*h, F.Compute(h*i, (y+Split)*h))
                        }, ColorL.Color, true));
            }
            //if (Split < 1.0)
            //    r.Add(new PolyLine3D(new List<Vector>()
            //    {
            //            new Vector(x, y*h, F.Compute(x, y*h)),
            //            new Vector(h*(i+Split), y*h, F.Compute(h*(i+Split), y*h)),
            //            new Vector(h*(i+Split), (y+Split)*h, F.Compute(h*(i+Split), (y+Split)*h)),
            //            new Vector(x, (y+Split)*h, F.Compute(h*i, (y+Split)*h))
            //    }, true));
        
            return r;
        }
    }
}
