using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace POSApplication.Models;

public partial class PboPosContext : DbContext
{
    public PboPosContext()
    {
    }

    public PboPosContext(DbContextOptions<PboPosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Barang> Barangs { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//         => optionsBuilder.UseNpgsql("Host=localhost;Database=pbo_pos;Username=postgres;Password=farhan12");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Barang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("barang_pkey");

            entity.ToTable("barang");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hargajual)
                .HasPrecision(10, 2)
                .HasColumnName("hargajual");
            entity.Property(e => e.Nama)
                .HasMaxLength(100)
                .HasColumnName("nama");
            entity.Property(e => e.Stok).HasColumnName("stok");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
