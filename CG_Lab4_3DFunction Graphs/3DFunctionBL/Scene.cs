using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _3DFunctionBL
{
    public class Scene
    {
        public List<IModel> Models { get; set; }
        public Pen pen { get; set; }
       // public Brush brush { get; set; }
        public Scene()
        {
            Models = new List<IModel>();
        }
        public Scene(/*Color colorP, Color colorB,*/ float width)
        {
            //pen = new Pen(colorP, width);
           // Pen penB = new Pen(colorB, width);
            //brush = penB.Brush;
            
            if (Models == null)
                Models = new List<IModel>();
        }
        //public Scene(/*Color colorP,*/ float width)
        //{
        //   // pen = new Pen(colorP, width);
        //    //brush = pen.Brush;

        //    if (Models == null)
        //        Models = new List<IModel>();
        //}
       
        public  void DrawAll(Bitmap bmp, Camera cam, Screen scr)
        {
            //int split = 2;
            Graphics g = Graphics.FromImage(bmp);
            List<PolyLine3D> lines = new List<PolyLine3D>();
            foreach (IModel m in Models)
                foreach (PolyLine3D pl in m.GetLines()) 
                {
                    //pl.ColorL = m.ColorL;
                    List<Vector> vl = new List<Vector>();
                    foreach (Vector v in pl.Vertices)
                        vl.Add(cam.Convert(v));
                    lines.Add(new PolyLine3D(vl, pl.ColorL.Color/*, m.ColorL.Color*/));
                    
                }
           
            foreach (var pl in lines)
            {
                int index = lines.IndexOf(pl);
                List<Point> points = new List<Point>();
                foreach (Vector v in pl.Vertices)
                {
                    Point p = new Point();
                    
                    p = scr.Convert(v);
                    points.Add(p);
                    
                }
                 if (points.Count > 0)
                {
                    g.FillPolygon(pl.ColorL.Brush, points.ToArray());
                    g.DrawLines(Pens.Black, points.ToArray());
                }
            }
            
            g.Dispose();
        }
    }
}
