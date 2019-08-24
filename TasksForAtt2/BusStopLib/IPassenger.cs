using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStopLib
{
    public interface IPassenger
    {
        BusStop BusStop { get; set; }
        Bus Bus { get; set; }
        int AmoutOfStations { get; set; }
        void OnBus(Bus bus);
        void FromBus(BusStop busStop);
    }
}
