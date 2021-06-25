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
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(16)]
        [DisplayName("Proje Adı")]
        public string ProjectName { get; set; }

        [MaxLength(500)]
        [DisplayName("Proje Detayı")]
        public string ProjectDetail { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayName("Başlangıç Tarihi")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [DisplayName("Bitiş Tarihi")]
        public DateTime EndDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Satış Fiyatı")]
        public decimal Price { get; set; }



        public ICollection<EmployeeProject> EmployeeProjects { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<ToDoList> ToDoLists { get; set; }
    }
}
