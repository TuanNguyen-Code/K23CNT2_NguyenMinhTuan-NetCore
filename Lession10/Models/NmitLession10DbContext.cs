using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lession10.Models;

public partial class NmitLession10DbContext : DbContext
{
    public NmitLession10DbContext()
    {
    }

    public NmitLession10DbContext(DbContextOptions<NmitLession10DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TUAN-LAPTOP\\SQLEXPRESS;Database=NmitLession10DB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("category");

            entity.Property(e => e.CateId)
                .ValueGeneratedNever()
                .HasColumnName("cateID");
            entity.Property(e => e.CateName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("cateName");
            entity.Property(e => e.CateStatus).HasColumnName("cateStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
