using System;
using System.Collections.Generic;

namespace WebApplication8.Models
{
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
            Inventory = new HashSet<Inventory>();
            Staff = new HashSet<Staff>();
        }

        public int StoreId { get; set; }
        public byte ManagerStaffId { get; set; }
        public int AddressId { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual Address Address { get; set; }
        public virtual Staff ManagerStaff { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
