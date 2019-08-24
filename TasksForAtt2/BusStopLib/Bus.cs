using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStopLib
{
    public class Bus
    {
        internal event Action<BusStop> BusStopEvent;
        internal bool IsFull { get; set; }
        const double velicity = 6;
        internal event Action<Bus> FullEvent;
        public double X { get; set; }
        internal int StopTime = 0;
        public int sits = 3;
        public double Y { get; set; }
        double WidthScr { get; set; }
        public double Length { get; set; }
        double FirtLevel { get; set; }
        double SecondLevel { get; set; }
        public List<IPassenger> Passengers { get; set; } = new List<IPassenger>();
        public bool Disappeared { get; set; }
        internal void StopOn(BusStop busStop)
        {
            lock (busStop.Passengers)
            {
                StopTime = 20;
                BusStopEvent?.Invoke(busStop);
                IsFull = false;
                busStop.waitingTime = 0;
                busStop.Revolt = false;
            }

        }
       
        public Bus(List<IPassenger> passengers = null)
        {
            if (passengers == null)
                Passengers = new List<IPassenger>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusStopEvent += passenger.FromBus;
                passenger.Bus = this;
                //passenger.Moving = true;
            }
        }
        public Bus(double x, double y, double width, double length, double fl, double sl)
        {
            X = x;
            Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
            Disappeared = false;
        }
        public Bus(double x, double y, double width, double length, double fl, double sl, List<IPassenger> passengers = null)
        {
            X = x;
            Y = y;
            WidthScr = width;
            Length = length;
            FirtLevel = fl;
            SecondLevel = sl;
            if (passengers == null)
                Passengers = new List<IPassenger>();
            else
                Passengers = passengers;
            foreach (var passenger in Passengers)
            {
                BusStopEvent += passenger.FromBus;
                passenger.Bus = this;
            }
        }

        internal void CheckOnFull()
        {
            IsFull = true;
            FullEvent?.Invoke(this);
            if (Passengers.Count < sits)
                IsFull = false;
            if (IsFull)
                StopTime = -1;
        }
        
        public void TimeTick()
        {
            if (StopTime < 0)
            {
                X -= velicity;
                if (!(X > Length && X < WidthScr))
                {
                    X = WidthScr - Length;
                    if (Y == FirtLevel + 76)
                    {
                        Y = SecondLevel + 76;
                    }
                    else
                    {
                        Y = FirtLevel + 76;
                    }
                }
            }
            StopTime--;
        }
        
    }
}
