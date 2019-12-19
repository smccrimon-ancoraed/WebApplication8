using System;
using System.Collections.Generic;

namespace WebApplication8.Models
{
    public partial class Addressdb
    {
        public int AddressId { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string District { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
