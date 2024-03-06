using System.Data.Entity;
using comp4945assignment3.Models;

namespace comp4945assignment3
{
    public class AppContext : DbContext
    {
        public AppContext() : base("ServiceProviderDB")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Empployees { get; set; }
        public DbSet<Service> Services { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map inheritance hierarchy
            modelBuilder.Entity<Person>()
                .Map<Employee>(m => m.Requires("Discriminator").HasValue("Employee"))
                .Map<Customer>(m => m.Requires("Discriminator").HasValue("Customer"));
            
            // Configure many-to-many relationship between customers and services
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Req_Services)
                .WithMany(s => s.Customers_Req)
                .Map(cs =>
                {
                    cs.MapLeftKey("Id");
                    cs.MapRightKey("ServiceId");
                    cs.ToTable("Customer_Service");
                });
            
            // Configure one-to-many relationship between employees and services
            modelBuilder.Entity<Employee>()
                .HasRequired<Service>(e => e.Qualififed_Service)
                .WithMany(s => s.Emp_Qualified)
                .HasForeignKey<int>(e => e.Qualififed_Service.SericeId);
        }
    }
}