using CityBusManagement.DAL.Repository;
using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBusManagement.BAL.services
{
    public class BusDetailsService
    {
        IBusDetailsRepository _busDetailsRepository;

        public BusDetailsService(IBusDetailsRepository busDetailsRepository)
        {
            _busDetailsRepository = busDetailsRepository;
        }
        public void AddBusDetails(BusDetails busdetails)
        {
            _busDetailsRepository.AddBusDetails(busdetails);
        }
        public void DeleteBusDetails(int busNo)
        {
            _busDetailsRepository.DeleteBusDetails(busNo);
        }
        public void UpdateBusDetails(BusDetails busdetails)
        {
            _busDetailsRepository.UpdateBusDetails(busdetails);
        }
        public void GetBusNo(int busNo)
        {
            _busDetailsRepository.GetBusNo(busNo);
        }
        public IEnumerable<BusDetails> GetBusDetails()
        {
            return _busDetailsRepository.GetBusDetails().ToList();
        }
    }
}
