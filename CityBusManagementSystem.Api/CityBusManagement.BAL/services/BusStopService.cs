using CityBusManagement.DAL.Repository;
using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBusManagement.BAL.services
{
    public class BusStopService
    {
        IBusStopRepository _busStopRepository;

        public BusStopService(IBusStopRepository busStopRepository)
        {
            _busStopRepository = busStopRepository;
        }

        public void AddBusStop(BusStop busstop)
        {
            _busStopRepository.AddBusStop(busstop);
        }
        public void DeleteBusStop(int busno)
        {
            _busStopRepository.DeleteBusStop(busno);
        }
        public void UpdateBusStop(BusStop busstop)
        {
            _busStopRepository.UpdateBusStop(busstop);
        }
        public void GetBusNo(int busno)
        {
            _busStopRepository.GetBusNo(busno);
        }
        public IEnumerable<BusStop> GetBusStop()
        {
            return _busStopRepository.GetBusStop().ToList();
        }
    }
}
    

