using Microsoft.EntityFrameworkCore;

namespace Karpaty.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<House> Houses { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<RoomHouse> RoomHouses { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<Admin> DictAdmins { get; set; } = null!;


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
