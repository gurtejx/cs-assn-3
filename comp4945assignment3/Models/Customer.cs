namespace comp4945assignment3.Models
{
    public class Customer : Person
    {
        public ICollection<Service> Req_Services { get; set; }
    }
}