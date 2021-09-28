using GeoClient.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient
{
    public interface IAirportClient
    {
        IEnumerable<PlacesResponse> GetClosestPlaces(string remoteIPAddress);
        IEnumerable<PlacesResponse> GetClientAirports(string clientCityId);
        IEnumerable<Continent> GetAllContinents();


    }
}
