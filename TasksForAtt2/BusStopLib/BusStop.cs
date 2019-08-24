using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BusStopLib
{
    public class BusStop
    {
        public int X { get; set; }
        public int Y { get; set; }
        public List<IPassenger> Passengers { get; set; }
        internal event Action<Bus> BusEvent;

        public int RB { get; set; }
        public int BB { get; set; }
        public int waitingTime;
        public bool Revolt { get; set; }

        public List<IPassenger> ToAdd = new List<IPassenger>();
        internal void Add()
        {
            foreach (var item in ToAdd)
            {
                BusEvent += item.OnBus;
            }
            Passengers.AddRange(ToAdd);
            ToAdd.Clear();
        }
        internal void Stop(Bus bus)
        {
            BusEvent?.Invoke(bus);
        }
        public BusStop(List<IPassenger> passengers = null)
        {
            if (passengers == null)
                Passengers = new List<IPassenger>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusEvent += passenger.OnBus;
                passenger.BusStop = this;
            }

        }
       
      
        public BusStop(int x, int y, int rb, int bb)
        {
            X = x;
            Y = y;
            RB = rb;
            BB = bb;
            Passengers = new List<IPassenger>();
            Revolt = false;
        }

        public void TimeTick()
        {
            if (Passengers.Count != 0)
                waitingTime++;
            if (waitingTime == 50)
                Revolt = true;
            Random rnd = new Random();
            int possibl = rnd.Next(0, 10);
            if(possibl== 0)
            {
                if (Passengers.Count < 5)
                {
                    int N = rnd.Next(0, 2);
                    for (int i = 0; i < N; i++)
                    AddPassenger();
                }
            }
        }

        public void AddPassenger()
        {
            Random rnd = new Random();
            SimpleMan simpleMan = new SimpleMan(rnd.Next(1, 2));
            BusEvent += simpleMan.OnBus;
            simpleMan.BusStop = this;
            Passengers.Add(simpleMan);

        }
    }
}
