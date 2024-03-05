using System;

namespace CS_assn_3.Models
{
    public class Customer : Person
    {
        public ICollection<Service> Req_Services { get; set; }
    }
}