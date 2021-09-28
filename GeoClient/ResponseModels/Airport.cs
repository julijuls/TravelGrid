using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient.ResponseModels
{
    public class Airport
    {
        public string CityId { get; set; }
        public string CountryId { get; set; }
        public string Location { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
