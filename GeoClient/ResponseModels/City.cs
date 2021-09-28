using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient.ResponseModels
{
    public class City
    {
        public bool SingleAirportCity { get; set; }
        public string CountryId { get; set; }
        public string Location { get; set; }
        public string IataCode { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Airport> Airports { get; set; }
    }
}
