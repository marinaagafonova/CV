using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace FractalsLibrary.NewM
{
    
    public class NewMandelbrot
    {
        private const int MAX = 256;      // max iterations
        public ParamForJandM Domain;
        private const int ScaleUp = 255;
        public int x1, y1, xs, ys, xe, ye;
        public  double xstart, ystart, xende, yende, xzoom, yzoom;
        public bool action, rectangle;
        public float xy;
        private readonly Graphics g1;
        private readonly Bitmap bitmap;

        private Pen pen;
       

        public NewMandelbrot(int x1, int y1, ParamForJandM d)
        {
            this.x1 = x1;
            this.y1 = y1;
            xy = (float)x1 / (float)y1;
            bitmap = new Bitmap(x1, y1);
            g1 = Graphics.FromImage(bitmap);
            Domain = d;
        }

        public void Start()
        {
            action = false;
            rectangle = false;
            InitValues();
            xzoom = (xende - xstart) / x1;
            yzoom = (yende - ystart) / y1;
            Mandelbrot();
        }
        public void UpdateDomain(ParamForJandM d)
        {
            Domain = d;
        }
        public void InitValues()
        {
            xstart = Domain.Xmin;
            ystart = Domain.Ymin;
            xende = Domain.Xmax;
            yende = Domain.Ymax;
            if ((float)((xende - xstart) / (yende - ystart)) != xy)
                xstart = xende - (yende - ystart) * xy;
        }

        

        public void Mandelbrot() // расчёт всех точек
        {
            int x, y;
            float h, brightness, alt = 0.0f;

            action = false;
           
            for (x = 0; x < x1; x += 1) //с SetPixel х++
                for (y = 0; y < y1; y++)
                {
                    h = PointСolour(xstart + xzoom * x, ystart + yzoom * y); // colour value
                    if (h != alt)
                    {
                        brightness = 1.0f - h * h; 

                        var customColour = new HSBColor(h * ScaleUp, 0.8f * ScaleUp, brightness * ScaleUp); // hsb colour
                        var convertedColour = HSBColor.FromHSB(customColour); 
                        
                        pen = new Pen(convertedColour);
                        alt = h;
                        //if (x == 700 && y==400)
                        //    MessageBox.Show(h.ToString() + " " + brightness.ToString());
                    }
                    
;                    bitmap.SetPixel(x, y, pen.Color);
                }
            action = true;
        }

        private float PointСolour(double xwert, double ywert) // colour value from 0.0 to 1.0 by iterations 
        {
            double r = 0.0, i = 0.0, m = 0.0;

            var jReference = 0;

            while ((jReference < MAX) && (m < 4.0))
            {
                jReference++; 
                m = r * r - i * i;
                i = 2.0 * r * i + ywert;
                r = m + xwert;
            }
            return (float)jReference / (float)MAX; 
        }
        public void Update(Graphics g)
        {
            g.DrawImage(bitmap, 0, 0);
            if (rectangle)
            {
                pen = new Pen(Color.White);
                if (xs < xe)
                {
                    if (ys < ye)
                        g.DrawRectangle(pen, xs, ys, (xe - xs), (ye - ys));
                    else
                        g.DrawRectangle(pen, xs, ye, (xe - xs), (ys - ye));
                }
                else
                {
                    if (ys < ye)
                    {
                        g.DrawRectangle(pen, xe, ys, (xs - xe), (ye - ys));
                    }
                    else
                    {
                        g.DrawRectangle(pen, xe, ye, (xs - xe), (ys - ye));
                    }
                }

                pen.Dispose(); 
            }
        }

    }
}
