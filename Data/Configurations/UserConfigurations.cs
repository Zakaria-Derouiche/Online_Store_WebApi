using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

        }
    }
}
