using Assignment4_DIS.Models;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Assignment4_DIS.APIHandlerManager 
{
    public class APIHandler
{
    static string BASE_URL = "https://developer.nrel.gov/api/alt-fuel-stations/v1/nearest.json?";
    static string API_KEY = "h3nD00CFqjd6UuNPe3bZj4iStQ2ZEF6WQvbnSwEL";

    HttpClient httpClient;
    public APIHandler()
    {
        httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
        httpClient.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    }
    


    public Stations GetStations()
        {
            
            string extension = "&location=Tampa&status=E&access=public&_fields=fuel_stations.station_name";

            Stations stations = GetStationWithLocation( extension);

            return stations;
        }

        public Stations GetStationWithLocation(string extension)
        {
            string API_PATH = BASE_URL + "api_key=" + API_KEY;
            string stationsData = "";

            Stations stations = new Stations();
            stations.data = new List<Station>();

            httpClient.BaseAddress = new Uri(API_PATH + extension);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(API_PATH + extension).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    stationsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!stationsData.Equals(""))
                {
                    JObject myObject = JObject.Parse(stationsData);
                    //var reponseObj = JsonConvert.DeserializeObject<List<Station>>(stationsData);
                    foreach (var item in myObject)
                    {
                        if (item.Key == "fuel_stations")
                        {
                            foreach (var st in item.Value)
                            {
                                Console.WriteLine(st.ToString());
                                Station station = JsonConvert.DeserializeObject<Station>(st.ToString());
                                stations.data.Add(station);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            return stations;
        }
    }
}

