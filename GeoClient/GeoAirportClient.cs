using GeoClient.ResponseModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient
{

    public class GeoAirportClient : IAirportClient
    {

        private readonly IAirportClientConfiguration _airportClientConfiguration;
        private readonly RestClient _restClient;

        public GeoAirportClient(IAirportClientConfiguration airportClientConfiguration)
        {
            _airportClientConfiguration = airportClientConfiguration;
            _restClient = new RestClient(airportClientConfiguration.BaseUrl);
        }

        public IEnumerable<PlacesResponse> GetClosestPlaces(string ipAddress) 
        {
            var request = new RestRequest("autosuggest/v1.0/UA/GBP/en-GB", Method.GET);
            request.AddParameter("id", $"{ipAddress}-ip");
            request.AddParameter("apiKey", "prtl6749387986743898559646983194");
            var result = _restClient.Get<GeoResponse>(request);
            return result.Data.Places;

        }
       
        public IEnumerable<PlacesResponse> GetClientAirports(string clientCityId) {
            var request = new RestRequest("autosuggest/v1.0/UK/GBP/en-GB", Method.GET);
            request.AddParameter("query", clientCityId);
            request.AddParameter("apiKey", "prtl6749387986743898559646983194");
            var result = _restClient.Get<GeoResponse>(request).Data.Places;
            return result;
        }

        public IEnumerable<Continent> GetAllContinents()
        {
            var request = new RestRequest("geo/v1.0", Method.GET);
            request.AddParameter("apiKey", "prtl6749387986743898559646983194");
            var result = _restClient.Get<ContinentResponse>(request);
            return result.Data.Continents;

        }
    }
  
    
}
