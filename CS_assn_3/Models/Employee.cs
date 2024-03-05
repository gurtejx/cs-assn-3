using System;

namespace CS_assn_3.Models
{
    public class Employee : Person
    {
        public string Role { get; set; }
        public Service Qualififed_Service { get; set; }
    }
}