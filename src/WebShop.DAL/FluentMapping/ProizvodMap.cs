using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebShop.DAL.Models;

namespace WebShop.DAL.FluentMapping
{
    public class ProizvodMap : IEntityTypeConfiguration<Proizvod>
    {
        public void Configure(EntityTypeBuilder<Proizvod> entity)
        {
            entity.ToTable("Proizvod");
            entity.Property(e => e.Naziv)
                  .HasMaxLength(50);
            entity.Property(e => e.Sifra)
                  .HasMaxLength(20);
            entity.Property(e => e.KratakOpis)
                  .HasMaxLength(500)
                  .IsRequired(false);
            entity.Property(e => e.Opis)
                  .HasMaxLength(500)
                  .IsRequired(false);
            entity.Property(e => e.KategorijaId)
                .IsRequired(false);

            entity.HasOne(e => e.Kategorija)
                .WithMany(p => p.Proizvodi)
                .HasForeignKey(d => d.KategorijaId)
                .HasConstraintName("FK_Proizvod_Kategorija");
        }
    }
}
