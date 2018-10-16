using Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Logic
{
    public class User : IdentityUser, IUser
    {
    }

    public class PraiseDbContext : IdentityDbContext<User>
    {
        public PraiseDbContext() : base("PraiseZone")
        {

        }


        public DbSet<Member> Member { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Sermon> Sermon { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<EventType> Eventtype { get; set; }
      
        public DbSet<SermonCategory> SermonCategories { get; set; }



       

       

    }
}

