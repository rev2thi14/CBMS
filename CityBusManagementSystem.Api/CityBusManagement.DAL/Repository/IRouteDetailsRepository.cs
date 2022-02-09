using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
   public  interface IRouteDetailsRepository
    {
        public void AddRouteDetails(RouteDetails routedetails);
        public void UpdateRouteDetails(RouteDetails routedetails);
        public void DeleteRouteDetails(int routeNo);
        public RouteDetails GetRouteNo(int routeNo);
        IEnumerable<RouteDetails> GetRouteDetails();
        IEnumerable<RouteDetails> GetRoutesDetails();
    }
}
