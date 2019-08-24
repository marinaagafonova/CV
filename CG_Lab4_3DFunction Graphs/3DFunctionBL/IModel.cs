using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _3DFunctionBL
{
    public interface IModel
    {
        List<PolyLine3D> GetLines();
        Pen ColorL { get; set; }
    }
}
