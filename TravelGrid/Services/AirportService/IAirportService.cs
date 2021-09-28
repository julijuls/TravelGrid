using GeoClient.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelGrid.Services.AirportService.Models;

namespace TravelGrid.Services.AirportService
{
    public interface IAirportService
    {
      
        IEnumerable<PlacesResponse> GetClosestAirports(string remoteIpAddress);
        IEnumerable<PlacesResponse> GetAirportsByCity(string clientCityId);
        IEnumerable<CountryInfo> GetAllCountries();
    }
}
