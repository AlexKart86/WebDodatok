using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Karpaty.ViewModels
{
    public class AddRequestModel
    {
        [Key]
        public int RequestId { get; set; }
        [Required]
        [DisplayName("Ваше ПІБ")]
        public string ClientPIB { get; set; } = null!;
        [Required]
        [DisplayName("Контактний телефон")]
        public string ClientPhone { get; set; } = null!;
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Некоректна email-адреса")]
        public string? ClientEmail { get; set; }
        [Required]
        [DisplayName("Кількість гостей")]
        public int? PersonCount { get; set; }

        [Required]
        [DisplayName("Дата заїзду")]
        public DateTime? DateStart { get; set; }

        [DisplayName("Дата від'їзду")]
        [Required]
        public DateTime? DateEnd { get; set; }

        [DisplayName("Оберіть будинок")]
        public int HouseId { get; set; }

        //[DisplayName("Оберіть кімнату")]
        //public int RoomId { get; set; }

        [DisplayName("Коментар")]
        public string Comment { get; set; }

        public SelectList Houses { get; set; }
        public SelectList Rooms { get; set; }
        public SelectList PeopleDropdown { get; set; }
    }
}
