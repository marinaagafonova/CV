using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystemBL
{
    public class SolarSystem1
    {
        public List<Planet1> Planets { get; set; }
        public SolarSystem1()
        {
            Planets = new List<Planet1>();
        }
        public void Draw(Graphics g)
        {
            g.Clear(Color.Black);
            for (int i = 0; i < Planets.Count; i++)
            {
                Planets[i].Move();
                g.FillEllipse(Brushes.Blue, Planets[i].X, Planets[i].Y, 20, 20);
            }
        }

    }
}
