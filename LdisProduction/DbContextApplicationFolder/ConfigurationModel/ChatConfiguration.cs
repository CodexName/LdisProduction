using LdisProduction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LdisProduction.DbContextApplicationFolder.ConfigurationModel
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasMany(x => x.MessageId).WithMany(x => x.ChatId);
            builder.HasMany(x => x.UserId).WithMany(x => x.ChatId);
        }
    }
}