using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace demoapp.Models
{
    public partial class MusicStoreDatabaseContext : DbContext
    {
        public MusicStoreDatabaseContext()
        {
        }

        public MusicStoreDatabaseContext(DbContextOptions<MusicStoreDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MusicStoreDatabase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Picturedata).HasColumnName("Picturedata");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("Price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("ProductName");
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__TestTabl__B40CC6ED9F1A231B");

                entity.ToTable("TestTable");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PicFileName)
                    .HasMaxLength(100)
                    .HasColumnName("picFileName");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .HasColumnName("product_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
