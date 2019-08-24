using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalsLibrary
{
    public class Sierpinski
    {
        public void DrawTriangle(Graphics gr, int level, PointF topPoint, PointF leftPoint, PointF rightPoint)
        {
            if (level == 0)
            {
                PointF[] points = { topPoint, rightPoint, leftPoint };
                gr.FillPolygon(Brushes.Black, points);
            }
            else
            {
                PointF leftMid = new PointF(
                    (topPoint.X + leftPoint.X) / 2f,
                    (topPoint.Y + leftPoint.Y) / 2f);
                PointF rightMid = new PointF(
                    (topPoint.X + rightPoint.X) / 2f,
                    (topPoint.Y + rightPoint.Y) / 2f);
                PointF bottomMid = new PointF(
                    (leftPoint.X + rightPoint.X) / 2f,
                    (leftPoint.Y + rightPoint.Y) / 2f);

                DrawTriangle(gr, level - 1,
                    topPoint, leftMid, rightMid);
                DrawTriangle(gr, level - 1,
                    leftMid, leftPoint, bottomMid);
                DrawTriangle(gr, level - 1,
                    rightMid, bottomMid, rightPoint);
            }
        }
    }

}
