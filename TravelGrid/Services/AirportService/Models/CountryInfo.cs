using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGrid.Services.AirportService.Models
{
    public class CountryInfo:PlaceInfo
    {
        public IEnumerable<CityInfo> CityInfos { get; set; }
    }
    public class CityInfo:PlaceInfo
    {
  
    }
    public abstract class PlaceInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
