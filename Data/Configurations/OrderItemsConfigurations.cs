using Microsoft.EntityFrameworkCore;
using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Data.Configurations
{
    public class OrderItemsConfigurations : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> TypeBuilder)
        {
            
        }
    }
}
