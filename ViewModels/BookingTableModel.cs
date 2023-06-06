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
        public string DateEndStr
        {
            get
            {
                return DateEnd?.ToString("dd.MM.yyyy") ?? "";
            }
        }
        public int? HouseId { get; set; }
        public string HouseName { get; set; }
        public int? RoomId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string DateCreatedStr
        {
            get
            {
                return DateCreated?.ToString("dd.MM.yyyy HH:mm:ss") ?? "";
            }
        }
        public string? Comment { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get
            {
                switch(StatusId)
                {
                    case 0: return "Нова";
                    case -1: return "Скасовано";
                    case 1: return "Підтверджено";
                    default: return "";
                }
            }
        }
    }
}
