using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPIWithReactProject.Server.Models;

public partial class AdminDbContext : DbContext
{
    public AdminDbContext()
    {
    }

    public AdminDbContext(DbContextOptions<AdminDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminTable> AdminTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DIAMOND\\SQLEXPRESS;Database=AdminDB;Integrated Security=true;TrustServerCertificate=true ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminTable>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__AdminTab__719FE48831A8B3F9");

            entity.ToTable("AdminTable");
            entity.Property(e => e.AdminName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AdminEmail)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AdminDepartment)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AdminPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AdminPassword)
            .HasMaxLength(20)
            .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
