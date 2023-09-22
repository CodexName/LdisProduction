using LdisProduction.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LdisProduction.DbContextApplicationFolder.ConfigurationModel
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasMany(x => x.ChatId).WithMany(x => x.MessageId);
            builder.HasMany(x => x.UserId).WithMany(x => x.MessageId);
        }
    }
}
