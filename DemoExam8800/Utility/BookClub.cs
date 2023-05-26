using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoExam8800
{
    public partial class BookClub : DbContext
    {
        private static BookClub _context;

        public BookClub()
            : base("name=BookClub")
        {
        }

        public static BookClub GetContext()
        {
            if (_context == null)
            {
                _context = new BookClub();
            }
            return _context;
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PickupPoint> PickupPoints { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.CostOfBook)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Book)
                .HasForeignKey(e => e.BookID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Carts)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PickupPoint>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.PickupPoint1)
                .HasForeignKey(e => e.PickupPoint)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
