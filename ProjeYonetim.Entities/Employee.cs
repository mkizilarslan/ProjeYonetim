using ProjeYonetim.Entities.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetim.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        [DisplayName("Ad Soyad")]
        public string FullName { get; set; }

        [Required]
        [DisplayName("Cinsiyet")]
        public Gender Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayName("Doğum Tarihi")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DisplayName("Departman")]
        public Department Department { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(6,2)")]
        [DisplayName("Maaş")]
        public decimal Salary { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "date")]
        [DisplayName("Güncelleme Tarihi")]
        public DateTime LastUpdateDate { get; set; }


        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public List<Sales> Sales { get; set; }
        public List<ToDoList> ToDoLists { get; set; }
    }
}
