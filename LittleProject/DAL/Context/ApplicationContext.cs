using System.Data.Entity;
using DAL.Domain;

namespace DAL.Context
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
