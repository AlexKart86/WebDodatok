using System.ComponentModel.DataAnnotations;

namespace Karpaty.ViewModels
{
    public class BookingTableItem
    {
        [Key]
        public int RequestId { get; set; }
        public string ClientPIB { get; set; } = null!;

        public string ClientPhone { get; set; } = null!;
        public string? ClientEmail { get; set; }
        public int? PersonCount { get; set; }
        public DateTime? DateStart { get; set; }
        public string DateStartStr { get{
            return DateStart?.ToString("dd.MM.yyyy")??"";
        } } 
        public DateTime? DateEnd { get; set; }
        public int? HouseId { get; set; }
        public int? RoomId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Comment { get; set; }
        public int? StatusId { get; set; }
    }
}
