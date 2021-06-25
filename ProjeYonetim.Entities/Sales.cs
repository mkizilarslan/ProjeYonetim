using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjeYonetim.Entities
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(16)]
        [DisplayName("Müşteri Adı")]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(16)]
        [DisplayName("Proje Adı")]
        public string ProjectName { get; set; }

        [Required]
        [ForeignKey(nameof(Employee))]
        [DisplayName("Satış Çalışanı")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayName("Satış Tarihi")]
        public DateTime SalesDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Fiyat")]
        public decimal Price { get; set; }
    }
}
