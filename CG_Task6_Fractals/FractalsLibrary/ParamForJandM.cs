using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalsLibrary
{
    public class ParamForJandM
    {
        public double Xmin { get; set; }
        public double Xmax { get; set; }
        public double Ymin { get; set; }
        public double Ymax { get; set; }
        public ParamForJandM(double xmin, double xmax, double ymin, double ymax)
        {
            Xmin = xmin;
            Xmax = xmax;
            Ymin = ymin;
            Ymax = ymax;
        }
        public int CalculateM()
        {
            return (int)(Xmax * Xmax + Ymax * Ymax);
        }
    }
}
