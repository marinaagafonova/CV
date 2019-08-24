using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFunctionBL
{
    public class Fm1 : IFunction
    {
        public int Index { get { return -1; } }

        public override string ToString()
        {
            return "z = 1 + 2 * x * y - x - y";
        }
        public double Compute(double x, double y)
        {
            return 1 + 2 * x * y - x - y;
        }
    }
    public class F0 : IFunction
    {
        public int Index { get { return 0; } }


        public override string ToString()
        {
            return "z = sin(x) + cos(y)";
        }
        public double Compute(double x, double y)
        {
            return Math.Sin(x) + Math.Cos(y);
        }
    }
    public class F1 : IFunction
    {
        public int Index { get { return 1; } }


        public override string ToString()
        {
            return "z = e^sin(x*3) - cos (y^2)";
        }
        public double Compute(double x, double y)
        {
            return Math.Pow(Math.E, Math.Sin(x * 3)) - Math.Cos(y * y);
        }
    }
    public class F2 : IFunction
    {
        public int Index { get { return 2; } }

        public override string ToString()
        {
            return "z = x ^ 3 - y ^ 2";
        }
        public double Compute(double x, double y)
        {
            return x * x * x - y * y;
        }
    }
    public class F3 : IFunction
    {
        public int Index { get { return 3; } }

        public override string ToString()
        {
            return "z = x^(1/3) * sin(y)";
        }
        public double Compute(double x, double y)
        {
            return Math.Pow(x, 1 / 3) * Math.Sin(y); ;
        }
    }
    public class F4 : IFunction
    {

        public int Index { get { return 4; } }

        public override string ToString()
        {
            return "z = ln(x^2 + 1) / (y^2 + 2)";
        }
        public double Compute(double x, double y)
        {
            return Math.Log(x * x + 1) / (y * y + 2);
        }
    }
    public class F5 : IFunction
    {
        public int Index { get { return 5; } }

        public override string ToString()
        {
            return "z = (1 / (x^3 + 2)) + ln (y)";
        }
        public double Compute(double x, double y)
        {
            return y <= 0 ? 0 : ((1 / (x * x * x + 2)) + Math.Log(y));
        }
    }
    public class F6 : IFunction
    {
        public int Index { get { return 6; } }

        public override string ToString()
        {
            return "z = abs(y ^ 4 - y ^ 3 + x ^ 2 - x)";
        }
        public double Compute(double x, double y)
        {
            return Math.Abs(Math.Pow(y, 4) - y * y * y + x * x - x);
        }
    }
    public class F7 : IFunction
    {
        public int Index { get { return 7; } }

        public override string ToString()
        {
            return "z = x^4+y^4*(x^2+y^2)";
        }
        public double Compute(double x, double y)
        {
            return Math.Pow(x, 4) + Math.Pow(y, 4) * (x * x + y * y);
        }
    }
    public class F8 : IFunction
    {
        public int Index { get { return 8; } }

        public override string ToString()
        {
            return "z = e^((sin(x) + cos(x)) / (x^2 + 1)) ";
        }
        public double Compute(double x, double y)
        {
            return Math.Pow(Math.E, (Math.Sin(x) + Math.Cos(x)) / (x * x + 1));
        }
    }
}
