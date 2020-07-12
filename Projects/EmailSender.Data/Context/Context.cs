using EmailSender.Data.Models;
using System.Data.Entity;

namespace EmailSender.Data.Context
{
    public class Context : DbContext
    {
        public Context() : base("Persist Security Info=False;Initial Catalog=MasterDev;Data Source=DESKTOP-EN6Q4C3")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Email> Email { get; set; }

        public DbSet<Anexo> Anexo { get; set; }
    }
}
