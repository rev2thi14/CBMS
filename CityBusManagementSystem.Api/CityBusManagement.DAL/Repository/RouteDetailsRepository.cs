using CityBusManagement.DAL.Data;
using CityBusManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public class RouteDetailsRepository : IRouteDetailsRepository
    {
        RouteDetailsDbContext _routeDetailsDbContext;
        public RouteDetailsRepository(RouteDetailsDbContext routeDetailsDbContext)
        {
            _routeDetailsDbContext = routeDetailsDbContext;
        }
        public void AddRouteDetails(RouteDetails routedetails)
        {
            _routeDetailsDbContext.routedetails.Add(routedetails);
            _routeDetailsDbContext.SaveChanges();
        }

        public void DeleteRouteDetails(int routeNo)
        {
            var routedetails = _routeDetailsDbContext.routedetails.Find(routeNo);
            _routeDetailsDbContext.routedetails.Remove(routedetails);
            _routeDetailsDbContext.SaveChanges();
        }

        public IEnumerable<RouteDetails> GetRouteDetails()
        {
            return _routeDetailsDbContext.routedetails.ToList();
        }

        public RouteDetails GetRouteNo(int routeNo)
        {
            return _routeDetailsDbContext.routedetails.Find(routeNo);
        }

        public IEnumerable<RouteDetails> GetRoutesDetails()
        {
            return _routeDetailsDbContext.routedetails.ToList();
        }

        public void UpdateRouteDetails(RouteDetails routedetails)
        {
            _routeDetailsDbContext.Entry(routedetails).State = EntityState.Modified;
            _routeDetailsDbContext.SaveChanges();
        }
    }
}
