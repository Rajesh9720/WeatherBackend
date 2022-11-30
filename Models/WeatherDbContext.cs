using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDweather.Models;

public partial class WeatherDbContext : DbContext
{
    public WeatherDbContext()
    {
    }

    public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Weather> Weathers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH152\\SQLEXPRESS;Initial Catalog=WeatherDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Weather>(entity =>
        {
            entity.HasKey(e => e.LocationsId).HasName("PK__Weather__577CB0CEC8B24992");

            entity.ToTable("Weather");

            entity.Property(e => e.LocationsId).HasColumnName("locations_id");
            entity.Property(e => e.Clouds)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clouds");
            entity.Property(e => e.Feels)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("feels");
            entity.Property(e => e.Locations)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("locations");
            entity.Property(e => e.Precipitation)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("precipitation");
            entity.Property(e => e.Temp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("temp");
            entity.Property(e => e.WindSpeed)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("windSpeed");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
