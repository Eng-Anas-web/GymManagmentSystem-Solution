using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configrations
{
    public class TrainConfigration:GymUserConfigration<Trainer> , IEntityTypeConfiguration<Trainer>    
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.createdAt).HasDefaultValueSql("GetDate()");
            base.Configure(builder);
        }
    }
}
