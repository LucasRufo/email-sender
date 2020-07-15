using EmailSender.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmailSender.Data.Context
{
    public class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-EN6Q4C3;Initial Catalog=MasterDev;Integrated Security=True")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Email> Email { get; set; }
    }
}
