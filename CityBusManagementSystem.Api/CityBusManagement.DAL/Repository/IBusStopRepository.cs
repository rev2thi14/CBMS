using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public interface IBusStopRepository
    {
        public void AddBusStop(BusStop busstop);
        public void UpdateBusStop(BusStop busstop);
        public void DeleteBusStop(int routeNo);
        public BusStop GetBusNo(int busNo);
        IEnumerable<BusStop> GetBusStop();
    }
}
