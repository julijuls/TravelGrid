using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient.ResponseModels
{
    public class Country
    {
        public string CurrencyId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<City> Cities { get; set; }

    }
}
