using System.ComponentModel.DataAnnotations;

namespace Lesstion08.Models
{
    public class NmitAccount
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name = "Họ tên đầy đủ"),
            Required(ErrorMessage = "Không được để trống"),
        ]
        public string NmitFullName { get; set; }
        [
            Display(Name = "Email"),
            Required(ErrorMessage = "Không được để trống"),
            DataType(DataType.EmailAddress),
        ]
        public string NmitEmail { get; set; }
        [
            Display(Name = "Phone"),
            Required(ErrorMessage = "Không được để trống"),
            DataType(DataType.PhoneNumber),
        ]
        public string NmitPhone { get; set; }
        [
            Display(Name = "Địa chỉ thường trú"),
            Required(ErrorMessage = "Không được để trống"),
            StringLength(50, ErrorMessage = "Không quá 50 kí tự")
        ]
        public string NmitAddress { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Avarta { get; set; }
        [
            Display(Name = "Ngày Sinh"),
            Required(ErrorMessage = "Không được để trống"),
            DataType(DataType.Date),
        ]
        public DateTime NmitBirthDay { get; set; }
        [Required(ErrorMessage = "Không được để trống"),]
        public string NmitGender { get; set; }
        [Required(ErrorMessage = "Không được để trống"),]
        public string NmitPassword { get; set; }
        [Required(ErrorMessage = "Không được để trống"),]
        public string NmitFacebook { get; set; }
    }
}
