using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebShop.DAL.FluentMapping;

namespace WebShop.DAL.Models;

public partial class WebShopContext : DbContext
{
    public WebShopContext()
    {
    }

    public WebShopContext(DbContextOptions<WebShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kategorija> Kategorijas { get; set; }
    public virtual DbSet<Proizvod> Proizovds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new KategorijaMap());
        modelBuilder.ApplyConfiguration(new ProizvodMap());
    }
}
