using LdisProduction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LdisProduction.DbContextApplicationFolder.ConfigurationModel
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany(x => x.ChatId).WithMany(x => x.UserId);
            builder.HasMany(x => x.MessageId).WithMany(x => x.UserId);
        }
    }
}
