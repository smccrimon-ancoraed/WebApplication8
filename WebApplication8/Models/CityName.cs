using System;
using System.Collections.Generic;

namespace WebApplication8.Models
{
    public partial class CityName
    {
        public int CityId { get; set; }
        public short CountryId { get; set; }
        public DateTime LastUpdate { get; set; }
        public string CityName1 { get; set; }
    }
}
