using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGrid.Models
{
    public class AirportViewModel
    {
        public List<SelectListItem> ClosestAirports { get; set; }
        public List<SelectListItem> DestinationCountries { get; set; }
        public List<SelectListItem> DestinationCities { get; set; }
        public string SelectedAirportId  {get; set;}
        public string SelectedCountryId { get; set; }
        public string SelectedCityId { get; set; }
    }
}
