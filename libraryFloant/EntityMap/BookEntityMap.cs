using libraryFloant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace libraryFloant.EntityMap
{
    public class BookEntityMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasOne(_ => _.Writer)
                .WithMany(_ => _.Books)
                .HasForeignKey(_ => _.WriterId);
            builder.HasOne(_ => _.Genre)
                .WithMany(_ => _.Books)
                .HasForeignKey(_ => _.GenreId);

        }
    }
}
