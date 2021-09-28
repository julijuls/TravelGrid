using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using TravelGrid.Models;
using TravelGrid.Services.AirportService;

namespace TravelGrid.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAirportService _airportService;

        public HomeController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        public IActionResult Index()
        {
            var countryGroups = new Dictionary<string, SelectListGroup>();

            string remoteIpAddress = "185.19.4.219"; /*this.HttpContext.Connection.RemoteIpAddress.ToString();*/
            var res = _airportService.GetClosestAirports(remoteIpAddress);

            var destCountries = _airportService.GetAllCountries();

            var airportModel = new AirportViewModel
            {
                ClosestAirports = res.Select(airport => new SelectListItem
                {
                    Text = airport.PlaceName,
                    Value = airport.PlaceId

                }).OrderBy(airport => airport.Text).ToList(),

                DestinationCountries = destCountries.Select(country =>
                {
                    countryGroups.Add(country.Id, new SelectListGroup { Name = country.Id });

                    return new SelectListItem
                    {
                        Text = country.Name,
                        Value = country.Id

                    };
                }).OrderBy(country => country.Text).ToList(),

                DestinationCities = destCountries.SelectMany(country => country.CityInfos, (country, city) => new SelectListItem
                {
                    Text = city.Name,
                    Value = city.Id,
                    Group = countryGroups[country.Id]
                }).OrderBy(city => city.Text).ToList()
            };

            return View(airportModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
