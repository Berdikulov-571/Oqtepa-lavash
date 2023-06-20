using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OqTepaLavashProject;

public partial class OqTepaContext : DbContext
{
    public OqTepaContext()
    {
    }

    public OqTepaContext(DbContextOptions<OqTepaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<Zakaz> Zakazs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=oq_tepa;User Id=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("registration_pkey");

            entity.ToTable("registration");

            entity.HasIndex(e => e.Email, "registration_email_key").IsUnique();

            entity.HasIndex(e => e.Number, "registration_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(32)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasColumnName("name");
            entity.Property(e => e.Number)
                .HasMaxLength(32)
                .HasColumnName("number");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Zakaz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zakaz_pkey");

            entity.ToTable("zakaz");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_date");
            entity.Property(e => e.NameOfProduct)
                .HasMaxLength(50)
                .HasColumnName("name_of_product");
            entity.Property(e => e.NumOfProduct)
                .HasMaxLength(50)
                .HasColumnName("num_of_product");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phone_number");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
