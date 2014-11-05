using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereToGo.Core.Model;
namespace WhereToGo.Infrastructure
{
    public class RDbContext : DbContext
    {

        public RDbContext()
        {
            Database.SetInitializer<RDbContext>(new DropCreateDatabaseIfModelChanges<RDbContext>());
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Snaps> Snaps { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Address> Address { get; set; }


    }
}
