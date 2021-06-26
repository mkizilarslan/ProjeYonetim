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

        [ForeignKey(nameof(Sales))]
        public int SalesId { get; set; }
        [DisplayName("Satış Adı")]
        public Sales Sales { get; set; }

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


        public IList<EmployeeProject> EmployeeProjects { get; set; }
        public IList<Expense> Expenses { get; set; }
        public IList<ToDoList> ToDoLists { get; set; }
    }
}
