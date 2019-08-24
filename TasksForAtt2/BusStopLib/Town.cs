using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BusStopLib
{
    public class Town
    {
        internal event Action TimeTickEvent;
        public List<BusStop> BusStops { get; set; }
        public List<Bus> Buses { get; set; }
        public List<IPassenger> Passengers { get; set; }
        public int X { get; set; } // нужно для переноса
        public int Y { get; set; } // нужно для переноса
        const int firstLevel = 652;// нужно для переноса
        const int secondLevel = 199;// нужно для переноса
        Thread background;
        public Town(int x, int y)
        {
            X = x;
            Y = y;
            Buses = new List<Bus>();
            Passengers = new List<IPassenger>();
            background = new Thread(Background);
            background.Start();
        }
        public void AddBus(int n)
        {
            List<IPassenger> NewMen = new List<IPassenger>();
            for (int i = 0; i < n; i++)
            {
                NewMen.Add(new SimpleMan());
            }
            Random rnd = new Random();
            int index = rnd.Next(0, 3);

            Bus bus = new Bus(BusStops[index].X + 127, BusStops[index].Y + 76, X, 100, firstLevel, secondLevel);
            Passengers.AddRange(NewMen);
            Buses.Add(bus);
            TimeTickEvent += bus.TimeTick;
        }
        public void AddPassenger()
        {
            Random rnd = new Random();
            int stations = rnd.Next(1, 2);
            IPassenger NewMan = new SimpleMan(stations);
            int index = rnd.Next(0, 3);
            BusStops[index].Passengers.Add(NewMan);
        }

        public void Background()
        {
            while (true)
            {
                for (int i = 0; i < Buses.Count; i++)
                {
                    for (int j = 0; j < BusStops.Count; j++)
                    {
                        if (Math.Abs(Buses[i].X - BusStops[j].X) < 20 && Math.Abs(Buses[i].Y - BusStops[j].Y) < 100 && Buses[i].StopTime < -10)
                        {
                            Async(i, j);
                        }
                    }
                }
                Thread.Sleep(100);
            }

        }
        public async void Async(int i, int j)
        {
            await Task.Run(() => Buses[i].StopOn(BusStops[j]));
            await Task.Run(() => BusStops[j].Stop(Buses[i]));
        }

        public void TimeTick()
        {

            List<Bus> buses = new List<Bus>(Buses);
            foreach (var bus in buses)
            {
                bus.TimeTick();
                if (bus.Disappeared)
                    Buses.Remove(bus);
            }
            foreach (var busstop in BusStops)
                busstop.TimeTick();
        }

        public void RandomBusesAndPassengers()
        {
            int buscount = 0;
            Random rnd = new Random();
            foreach (var busstop in BusStops)
            {
                buscount++;
                if(buscount >2)
                    Buses.Add(new Bus(busstop.X + 127, busstop.Y + 76, X, 100, firstLevel, secondLevel));
                int P = rnd.Next(0, 4);
                for (int i = 0; i < P; i++)
                {
                    busstop.AddPassenger();
                    busstop.Passengers[i].BusStop = busstop;
                }
            }
        }
      
        
        public void Dispose()
        {
            background.Abort();
        }
    }
}
