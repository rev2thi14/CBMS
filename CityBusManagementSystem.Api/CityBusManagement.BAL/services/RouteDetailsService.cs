using CityBusManagement.DAL.Repository;
using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.BAL.services
{
   public  class RouteDetailsService
    {
        IRouteDetailsRepository _routeDetailsRepository;

        public RouteDetailsService(IRouteDetailsRepository routeDetailsRepository)
        {
            _routeDetailsRepository = routeDetailsRepository;
        }
        public void AddRouteDetails(RouteDetails routedetails)
        {
            _routeDetailsRepository.AddRouteDetails(routedetails);
        }
        public void DeleteRouteDetails(int routeNo)
        {
            _routeDetailsRepository.DeleteRouteDetails(routeNo);
        }
        public void UpdateRouteDetails(RouteDetails routedetails)
        {
            _routeDetailsRepository.UpdateRouteDetails(routedetails);
        }

        public IEnumerable<RouteDetails> GetRoutesDetails()
        {
            return _routeDetailsRepository.GetRoutesDetails();
        }

        public void GetRouteNo(int routeNo)
        {
            _routeDetailsRepository.GetRouteNo(routeNo);
        }

    }
}
