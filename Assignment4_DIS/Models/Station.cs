using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_DIS.Models
{
     public class Station
{
    [Key]
    public string station_name { get; set; }
    public string Location { get; set; }
    public string fuel_type_code { get; set; }
    public float distance { get; set; }
    public string access_days_time { get; set; }
    public string street_address { get; set; }
    public string city { get; set; }
    public int zip { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string ev_pricing { get; set; }
    public string ev_network { get; set; }
    
}

public class Stations
{
   
    public List<Station> data { get; set; }

}
}