using Microsoft.EntityFrameworkCore;

namespace TestApi
{
    public class UserDataContext:DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext>options):
            base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
        public DbSet<User> users { get; set; }
    }
}
