using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Orders.Models;

public partial class GeniiAnalyticsContext : DbContext
{
    public GeniiAnalyticsContext()
    {
    }

    public GeniiAnalyticsContext(DbContextOptions<GeniiAnalyticsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrdersId).HasName("PK__orders__B46F683302023816");

            entity.ToTable("orders");

            entity.Property(e => e.OrdersId)
                .ValueGeneratedNever()
                .HasColumnName("orders_id");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");
            entity.Property(e => e.OrderStatus).HasColumnName("order_status");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
