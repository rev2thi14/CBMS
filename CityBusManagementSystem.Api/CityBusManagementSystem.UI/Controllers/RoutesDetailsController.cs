
using CityBusManagement.Entity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CBMS.UI.Controllers
{
    public class RoutesDetailsController : Controller
    {
        private IConfiguration _configuration;
        public RoutesDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> RouteDetails()
        {
            IEnumerable<RouteDetails> routeDetails = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "RoutesDetails/GetRouteDetails";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        routeDetails = JsonConvert.DeserializeObject<IEnumerable<RouteDetails>>(result);
                    }
                }
            }
            return View(routeDetails);
        }
        public IActionResult RouteDetailsEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RouteDetailsEntry(RouteDetails routeDetails)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(routeDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "RoutesDetails/AddRouteDetails";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "RouteDetails  saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
        public async Task<IActionResult> GetRouteDetails()
        {
            IEnumerable<RouteDetails> routeResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "RoutesDetails/GetRouteDetails";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        routeResult = JsonConvert.DeserializeObject<IEnumerable<RouteDetails>>(result);
                    }
                }
            }
            return View(routeResult);
        }
        public async Task<IActionResult> UpdateRouteDetails(int routeNo)
        {
            RouteDetails routeResult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "RoutesDetails/UpdateRouteDetails?routeNo=" + routeNo;
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        routeResult = JsonConvert.DeserializeObject<RouteDetails>(result);
                    }
                }
            }
            return View(routeResult);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRouteDetails(RouteDetails routedetails)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(routedetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "RoutesDetails/UpdateRouteDetails";
                using (var response = await client.PutAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "RouteDetails details Updated successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();

        }



        public async Task<IActionResult> DeleteRouteDetails(int routeNo)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {

                string endPoint = _configuration["WebApiBaseUrl"] + "RoutesDetails/DeleteRouteDetails?routeNo=" + routeNo;
                using (var response = await client.DeleteAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Route details Deleted successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();

        }

    }
}
   

