using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Entities
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [DisplayName("Gider Adı")]
        public string ExpenseName { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10,2)")]
        [DisplayName("Tutar")]
        public decimal ExpenseAmount { get; set; }

        [ForeignKey(nameof(Project))]
        [DisplayName("Proje")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
