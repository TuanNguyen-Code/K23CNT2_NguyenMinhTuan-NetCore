using System.ComponentModel.DataAnnotations;

namespace Lession07.Models
{
    public class NmitEmployee
    {
        [Key]//khóa chính
        public int NmitId { get; set; }

        [Required]//trường thông tin bắt buộc phải nhập
        [StringLength(100)]//chiều dài chuỗi
        public string NmitName { get; set; }

        [DataType(DataType.Date)]//annotation để hiển thị và định dạng
        public DateTime NmitBirthDay { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string NmitEmail { get; set; }

        [Phone]
        [StringLength(15)]
        public string NmitPhone { get; set; }

        [Range(0, double.MaxValue)]//giới hạn giá trị
        public decimal NmitSalary { get; set; }

        public bool NmitStatus { get; set; }
    }
}
