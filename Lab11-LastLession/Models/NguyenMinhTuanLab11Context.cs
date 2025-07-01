using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab11_LastLession.Models;

public partial class NguyenMinhTuanLab11Context : DbContext
{
    public NguyenMinhTuanLab11Context()
    {
    }

    public NguyenMinhTuanLab11Context(DbContextOptions<NguyenMinhTuanLab11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NmitEmployee> NmitEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TUAN-LAPTOP\\SQLEXPRESS;Database=NguyenMinhTuanLab11;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NmitEmployee>(entity =>
        {
            entity.HasKey(e => e.NmitEmpId).HasName("PK__NmitEmpl__2FFA7A72AC9A00C1");

            entity.ToTable("NmitEmployee");

            entity.Property(e => e.NmitEmpId).ValueGeneratedNever();
            entity.Property(e => e.NmitEmpLevel).HasMaxLength(50);
            entity.Property(e => e.NmitEmpName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
