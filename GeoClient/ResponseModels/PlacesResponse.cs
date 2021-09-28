using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient.ResponseModels
{
   public class PlacesResponse
    {
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string CountryId { get; set; }
        public string RegionId { get; set; }
        public string CityId { get; set; }
        public string CountryName { get; set; }
    }
    public class GeoResponse
    {
        public IEnumerable<PlacesResponse> Places { get; set; }
    }
}
