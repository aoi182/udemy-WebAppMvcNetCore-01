using Microsoft.EntityFrameworkCore;

namespace WebAppCodeFirst.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        virtual public DbSet<Category> Categories { get; set; }
        virtual public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category")
                .HasKey(e => e.Id);
                
                entity.Property(e => e.Id)
                .HasColumnName("id");

                entity.Property(e => e.Code)
                .HasColumnName("code")
                .IsRequired(true)
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(120)
                .IsUnicode(true);

                entity.Property(e => e.Description)
                .HasColumnName("description")
                .HasMaxLength(520);

                entity.Property(e => e.Status)
                .HasColumnName("status")
                .HasDefaultValue(true);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product")
                .HasKey(e => e.Id);

                entity.Property(e => e.Id)
                .HasColumnName("id");

                entity.Property(e => e.Code)
                .HasColumnName("code")
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired()
                .HasMaxLength(120);

                entity.Property(e => e.SellingPrice)
                .HasColumnName("selling_price")
                .HasColumnType("decimal(11, 2)");

                entity.Property(e => e.Stock)
                .HasColumnName("stock")
                .IsRequired();

                entity.Property(e => e.Description)
                .HasColumnName("description")                
                .HasMaxLength(520)
                .IsUnicode(false);

                entity.Property(e => e.Status)
                .HasColumnName("status")
                .HasDefaultValue(true);

                entity.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_product_to_category");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
