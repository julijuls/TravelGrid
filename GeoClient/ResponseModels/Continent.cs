using System;
using System.Collections.Generic;
using System.Text;

namespace GeoClient.ResponseModels
{
    public class Continent
    {
        public IEnumerable<Country> Countries { get; set; }
    }
}
