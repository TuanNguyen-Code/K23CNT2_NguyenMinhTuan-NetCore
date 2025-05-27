using System.ComponentModel.DataAnnotations;

namespace Lession06.Models
{
    public class NmitEmployee
    {
        [Key]
        public int NmitId { get; set; }

        [Required]
        [StringLength(100)]
        public string NmitName { get; set; }

        [DataType(DataType.Date)]
        public DateTime NmitBirthDay { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string NmitEmail { get; set; }

        [Phone]
        [StringLength(15)]
        public string NmitPhone { get; set; }

        [Range(0, double.MaxValue)]
        public decimal NmitSalary { get; set; }

        public bool NmitStatus { get; set; }

    }
}
