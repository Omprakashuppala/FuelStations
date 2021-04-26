using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4_DIS.Models;
using Assignment4_DIS;
using Assignment4_DIS.DataAccess;
using Assignment4_DIS.APIHandlerManager;
using Newtonsoft.Json;
using System.Net.Http;

namespace Assignment4_DIS.Controllers
{
    public class StationsController : Controller
    {
        static string BASE_URL = "https://developer.nrel.gov/api/alt-fuel-stations/v1/nearest.json?";
        static string API_KEY = "&api_key=h3nD00CFqjd6UuNPe3bZj4iStQ2ZEF6WQvbnSwEL";

        HttpClient httpClient;
        Stations publicStations;

        private readonly APIHandler apiHandler = new APIHandler();

        public StationsController( )
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new
            System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet]
        public IActionResult Stations()
        {
            var stations = apiHandler.GetStations();
            ViewBag.location = "tampa";
            return View(stations);
        }

        [HttpPost]
        public IActionResult GetStationsWithLocation(string location)
        {
            
            string extension = "&location="+location+"&status=E&access=public&_fields=fuel_stations.station_name";
            var stations = apiHandler.GetStationWithLocation(extension);
            ViewBag.location = location;
            return View("Stations",stations);
        }

        public IActionResult Charts()
        {
            var stations = apiHandler.GetStations();
            return View(stations);
        }
        public IActionResult Details(string data)
        {
            int rowNumber = int.Parse(data.Split("+")[0]);
            string location = data.Split("+")[1];
            string extension = "&location=" + location + "&status=E&access=public&_fields=fuel_stations.station_name";
            var stations = apiHandler.GetStationWithLocation(extension);
            return View(stations.data[rowNumber]);
        }
    }

}

