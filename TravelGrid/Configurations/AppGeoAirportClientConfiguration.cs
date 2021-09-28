using GeoClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGrid.Configurations
{
    public class AppGeoAirportClientConfiguration : IAirportClientConfiguration
    {
        public string BaseUrl { get; set; }
    }
}
