using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Test.Models.BD
{
    public partial class GralContext : DbContext
    {
        public GralContext()
        {
        }

        public GralContext(DbContextOptions<GralContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Concept> Concept { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerTmp> CustomerTmp { get; set; }
        public virtual DbSet<Donuts> Donuts { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductTmp> ProductTmp { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local); DataBase=Gral;User Id=sa;Password=Temp123;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concept>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.SaleId);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Concept)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Concept)
                    .HasForeignKey(d => d.SaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Concept_Sale");
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.IdCourse);

                entity.Property(e => e.CourseName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerTmp>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("CustomerTMP");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductTmp>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("ProductTMP");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Count).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sale_Customer");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Role).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
