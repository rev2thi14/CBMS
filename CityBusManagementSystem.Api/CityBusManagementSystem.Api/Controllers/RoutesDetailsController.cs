using CityBusManagement.BAL.services;
using CityBusManagement.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBusManagementSystem.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesDetailsController : ControllerBase
    {
        private RouteDetailsService _routeDetailsService;
        public RoutesDetailsController(RouteDetailsService routeDetailsService)
        {
            _routeDetailsService = routeDetailsService;
        }
        [HttpGet("GetRouteDetails")]
        public IEnumerable<RouteDetails> GetRoutesDetails()
        {
            return _routeDetailsService.GetRoutesDetails();
        }


        [HttpPost("AddRouteDetails")]
        public IActionResult AddRouteDetails([FromBody] RouteDetails routeDetails)
        {
            _routeDetailsService.AddRouteDetails(routeDetails);
            return Ok("RouteDetails created successfully!!");
        }
        [HttpDelete("DeleteRouteDetails")]
        public IActionResult DeleteRouteDetails(int routeno)
        {
            _routeDetailsService.DeleteRouteDetails(routeno);
            return Ok("RouteDetails deleted successfully!!");
        }
        [HttpPut("UpdateRouteDetails")]
        public IActionResult UpdateRouteDetails([FromBody] RouteDetails routeDetails)
        {
            _routeDetailsService.UpdateRouteDetails(routeDetails);
            return Ok("RouteDetails updated successfully!!");
        }
    }
}


