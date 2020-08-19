namespace FoodOrderingManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodOrderingMSModel : DbContext
    {
        public FoodOrderingMSModel()
            : base("name=FoodOrderingMSModel")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<city_restaurant> city_restaurant { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<order_product> order_product { get; set; }
        public virtual DbSet<order_shipper> order_shipper { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<restaurant> restaurants { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<shipper> shippers { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.products)
                .WithRequired(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city>()
                .Property(e => e.city_name)
                .IsUnicode(false);

            modelBuilder.Entity<city>()
                .Property(e => e.city_zip_code)
                .IsUnicode(false);

            modelBuilder.Entity<city>()
                .HasMany(e => e.city_restaurant)
                .WithRequired(e => e.city)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<city>()
                .HasMany(e => e.users)
                .WithRequired(e => e.city)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comment>()
                .Property(e => e.comment_text)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.order_type)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.order_details)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.order_product)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.order_shipper)
                .WithRequired(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.card_number)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.card_date)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.card_cvv)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.product_name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.details)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.product_image)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.order_product)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<restaurant>()
                .Property(e => e.restaurant_name)
                .IsUnicode(false);

            modelBuilder.Entity<restaurant>()
                .Property(e => e.restaurant_address)
                .IsUnicode(false);

            modelBuilder.Entity<restaurant>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<restaurant>()
                .Property(e => e.restaurant_password)
                .IsUnicode(false);

            modelBuilder.Entity<restaurant>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<restaurant>()
                .HasMany(e => e.city_restaurant)
                .WithRequired(e => e.restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<restaurant>()
                .HasMany(e => e.comments)
                .WithRequired(e => e.restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<restaurant>()
                .HasMany(e => e.products)
                .WithRequired(e => e.restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<restaurant>()
                .HasMany(e => e.shippers)
                .WithRequired(e => e.restaurant)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .Property(e => e.role_name)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.restaurants)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<shipper>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<shipper>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<shipper>()
                .Property(e => e.identification_number)
                .IsUnicode(false);

            modelBuilder.Entity<shipper>()
                .HasMany(e => e.order_shipper)
                .WithRequired(e => e.shipper)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.comments)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
