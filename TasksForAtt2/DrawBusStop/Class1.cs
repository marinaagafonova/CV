using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStopLib;
using System.Drawing;

namespace DrawBusStop
{
    public class DrawField
    {
        Town Town;
        Bitmap bmp;
        Graphics g;
        Image ImBusstop { get; set; }
        Image ImPassenger { get; set; }
        Image ImBus { get; set; }
        Image ImRevolt { get; set; }
        public DrawField(Town town)
        {
            Town = town;
            bmp = new Bitmap(Town.X, Town.Y);
            g = Graphics.FromImage(bmp);
        }
        public DrawField(Town town, Image busstop, Image bus, Image passenger, Image revolt)
        {
            Town = town;
            ImBusstop = busstop;
            ImBus = bus;
            ImPassenger = passenger;
            ImRevolt = revolt;
            bmp = new Bitmap(Town.X, Town.Y);
            g = Graphics.FromImage(bmp);
        }
        public void DrawBusStop(BusStop bs)
        {
            g.DrawImage(ImBusstop, (float)bs.X, (float)bs.Y);
            if (bs.Revolt)
                g.DrawImage(ImRevolt, bs.X, bs.Y - 110);
            int i = 0;
            int dx = 0;
            if (bs.Passengers.Count != 0)
            {
                List<IPassenger> passag = new List<IPassenger>(bs.Passengers);
                dx = ImBusstop.Width / passag.Count;
                foreach (var passenger in passag)
                {
                    g.DrawImage(ImPassenger, (float)bs.X + dx * i, (float)bs.Y + 90);
                    i++;
                }
            }               
        }
        private void DrawBus(Bus bus)
        {

            if (bus.Passengers != null)
            {
                int i = 0;
                double dx = bus.Length / bus.Passengers.Count;

                List<IPassenger> passag = new List<IPassenger>(bus.Passengers);
                foreach (var passenger in passag)
                {
                    g.DrawImage(ImPassenger, (float)(bus.X + i * dx), (float)bus.Y);
                    i++;
                }
            }
            g.DrawImage(ImBus, (float)bus.X, (float)bus.Y);

        }

        public Bitmap GetBmp()
        {
            g.Clear(Color.White);
            foreach (var busstop in Town.BusStops)
            {
                DrawBusStop(busstop);
            }
            foreach (var bus in Town.Buses)
            {
                DrawBus(bus);
                bus.TimeTick();
            }
            return bmp;
        }
    }
}
