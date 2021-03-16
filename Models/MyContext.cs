using Microsoft.EntityFrameworkCore;

namespace tenant_turner.Models
{
// the MyContext class representing a session with our MySQL 
// database allowing us to query for or save data
public class MyContext : DbContext 
{ 
    public MyContext(DbContextOptions options) : base(options) { }
       // "users" table is represented by this DbSet "Users" - just an example of integrating a common model. obviously omit if project doesn’t have users
        public DbSet<User> Users {get;set;}
        public DbSet<Picture> Pictures {get;set;}
        public DbSet<Rental> Rentals {get;set;}
    }
}
