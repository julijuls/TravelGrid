using GeoClient;
using GeoClient.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelGrid.Models;
using TravelGrid.Services.AirportService.Models;

namespace TravelGrid.Services.AirportService
{
    public class AirportService : IAirportService
    {
        private readonly IAirportClient _airportClient;

        public AirportService(IAirportClient airportClient)
        {
            _airportClient = airportClient;
        }


        public IEnumerable<PlacesResponse> GetClosestAirports(string remoteIPAddress)
        {
            var closestPlaces = _airportClient.GetClosestPlaces(remoteIPAddress);
            var closestCityId = closestPlaces?.FirstOrDefault()?.CityId;
            var closestAirports = _airportClient.GetClientAirports(closestCityId)?.Where(airport => airport.CityId == closestCityId);
            return closestAirports;
        }
        public IEnumerable<PlacesResponse> GetAirportsByCity(string clientCityId) => _airportClient.GetClientAirports(clientCityId);

        public IEnumerable<CountryInfo> GetAllCountries() => _airportClient.GetAllContinents().SelectMany(continent => continent.Countries, MapContinentCountryToCountryInfo);

        private CountryInfo MapContinentCountryToCountryInfo(Continent continent, Country country)
        {
            return new CountryInfo
            {
                Id = country.Id,
                Name = country.Name,
                CityInfos = country.Cities.Select(MapToCityInfo)
            };
        }

        private CityInfo MapToCityInfo(City city) => new CityInfo
        {
            Id = city.Id,
            Name = city.Name,
        };
    }
}
