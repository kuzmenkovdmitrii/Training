using System.Data.Entity;
using task15.Models;

namespace task15.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
            : base("ProjectDB")
        {

        }
        
    }
}