using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.DAL.Models;

namespace WebShop.DAL.FluentMapping
{
    public class KategorijaMap : IEntityTypeConfiguration<Kategorija>
    {
        public void Configure(EntityTypeBuilder<Kategorija> entity)
        {
            entity.ToTable("Kategorija");
            entity.Property(e => e.Naziv)
                  .HasMaxLength(50);
            entity.Property(e => e.Opis)
                  .HasMaxLength(500)
                  .IsRequired(false);
        }
    }
}
