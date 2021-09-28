using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelGrid.Models
{
    public class AirportCollectionModel
    {
        public string CityId { get; set; }
        public string PlaceName { get; set; }
        public AirportViewModel Airport { get; set; }
    }
}
