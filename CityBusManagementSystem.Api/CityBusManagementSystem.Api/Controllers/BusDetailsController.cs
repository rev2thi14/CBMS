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
    public class BusDetailsController : ControllerBase
    {
        private BusDetailsService _busDetailsService;
        public BusDetailsController(BusDetailsService busDetailsService)
        {
            _busDetailsService = busDetailsService;
        }

        [HttpPost("AddBusDetails")]
        public IActionResult AddBusDetails([FromBody] BusDetails busdetails)
        {
            _busDetailsService.AddBusDetails(busdetails);

            return Ok("BusDetails  Added Successfully!!!");
        }

        [HttpGet("GetBusDetails")]
        public IEnumerable<BusDetails> GetBusDetails()
        {
            return _busDetailsService.GetBusDetails();
        }

        [HttpDelete("DeleteBusDetails")]
        public IActionResult DeleteBusDetails(int busNo)
        {
            _busDetailsService.DeleteBusDetails(busNo);
            return Ok("Bus Details Deleted Successfully!!!");
        }

        [HttpPut("UpdateBusDetails")]
        public IActionResult UpdateBusDetails([FromBody] BusDetails busDetails)
        {
            _busDetailsService.UpdateBusDetails(busDetails);
            return Ok("Bus Details Updated Successfully!!!");
        }
    }
}
