using LdisProduction.DbContextApplicationFolder;
using LdisProduction.DbContextApplicationFolder.ConfigurationModel;
using LdisProduction.Models;
using Microsoft.EntityFrameworkCore;

namespace LdisProduction.DbContextApplication
{
    public class DbContextApplications : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbContextApplications(DbContextOptions<DbContextApplications> options) : base (options)
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConfigurationJsonSecret = new ConfigurationBuilder().AddUserSecrets<DbContextApplications>().Build();
            var ConnectionString = ConfigurationJsonSecret.GetConnectionString("DataBaseConnect");
            optionsBuilder.UseSqlite(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ChatConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
        }
    }
}
