using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalsLibrary
{
    public class Julia
    {
      
        private ParamForJandM Domain { get; set; }
        public Julia(ParamForJandM param)
        {
            Domain = param;
        }
        public void Draw(Bitmap bmp, double p0, double q0)
        {
            int a = bmp.Height, b = bmp.Height, kmax = 200/*, m = 8*/;
            int m = Domain.CalculateM();

            double x0, y0, dx, dy, x, y, r;
            double p = p0, q = q0;
            dx = (Domain.Xmax - Domain.Xmin) / (a - 1.0);
            dy = (Domain.Ymax - Domain.Ymin) / (b - 1.0);
           
            for (int nx = 0; nx <= a; nx++)
            { for (int ny = 0; ny <= b; ny++)
                {
                    int k = 0;
                    x0 = Domain.Xmin + nx*dx;
                    y0 = Domain.Ymin + ny*dy;
                    r = 0.0;
                    while ((k++ <= kmax) && (r < m))
                    {
                        x = x0;
                        y = y0;
                        x0 = x*x - y*y + p;
                        y0 = 2.0*x*y + q;
                        r = x0*x0 + y0*y0;
                    }
                    if (r > m)
                    {
                        if (k < 20)
                            k*= 10;
                        if (k > 255)
                            k = 255;
                        if(nx>0 && nx < bmp.Height && ny>0 && ny< bmp.Height)
                        bmp.SetPixel(nx, ny, Color.FromArgb(100, k, k, 255 - k));
                    }
                    else
                    {
                        bmp.SetPixel(nx, ny, Color.Black);
                    }
                }
            }
          
        }
    }
}
