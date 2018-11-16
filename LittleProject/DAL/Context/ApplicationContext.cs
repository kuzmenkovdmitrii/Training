using System.Data.Entity;
using Common.Entities;

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
