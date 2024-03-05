using System.Data.Entity;
using CS_assn_3.Models;

namespace CS_assn_3
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}