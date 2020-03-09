using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pencil.Models.Db
{
    public partial class PencilContext : DbContext
    {
        public PencilContext()
        {
        }

        public PencilContext(DbContextOptions<PencilContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BuyerTable> BuyerTable { get; set; }
        public virtual DbSet<PencilTable> PencilTable { get; set; }

        /*public PencilContext(DbContextOptions<PencilContext> options)
: base(options)
        { }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyerTable>(entity =>
            {
                entity.HasKey(e => e.BuyerId);

                entity.Property(e => e.BuyerId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PencilTable>(entity =>
            {
                entity.HasKey(e => e.PencilId)
                    .HasName("PK__PencilTa__1F2EA2C384315400");

                entity.Property(e => e.PencilId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.HasOne(d => d.BuyerId1Navigation)
                    .WithMany(p => p.PencilTableBuyerId1Navigation)
                    .HasForeignKey(d => d.BuyerId1)
                    .HasConstraintName("FK_PencilTable_BuyerTable");

                entity.HasOne(d => d.BuyerId2Navigation)
                    .WithMany(p => p.PencilTableBuyerId2Navigation)
                    .HasForeignKey(d => d.BuyerId2)
                    .HasConstraintName("FK_PencilTable_BuyerTable1");

                entity.HasOne(d => d.BuyerId3Navigation)
                    .WithMany(p => p.PencilTableBuyerId3Navigation)
                    .HasForeignKey(d => d.BuyerId3)
                    .HasConstraintName("FK_PencilTable_BuyerTable2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
