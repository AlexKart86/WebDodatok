using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Karpaty.Models
{
    public class House
    {
        [Key]
        public int HouseId { get; set; }
        public string Name { get; set; } = null!;
    }

    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public string RoomName { get; set; } = null!;
        public string? RoomDescription { get; set; } 
        [Required]
        public int PersonCount { get; set; }
    }

    public class RoomHouse
    {
        [Key]
        public int RoomHauseId { get; set;}
        public int RoomId { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; } = null!;
        public Room Room { get; set; } = null!;

    }
}
