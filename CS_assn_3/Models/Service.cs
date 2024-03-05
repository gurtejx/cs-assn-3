using System;

namespace CS_assn_3.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Emp_Qualified { get; set; }
        public ICollection<Customer> Customers_Req { get; set; }
    }
}