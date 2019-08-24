using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DFunctionBL
{
    public interface IFunction
    {
        int Index { get;}
        string ToString();
        double Compute(double x, double y);
        
    }
}
