using ProjeYonetim.Entities.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeYonetim.Entities
{
    public class ToDoList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(16)]
        [DisplayName("Yapılacak Adı")]
        public string ToDoName { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Yapılacak İçeriği")]
        public string ToDoContent { get; set; }

        [Required]
        [DisplayName("Öncelik")]
        public Priority Priority { get; set; }


        [ForeignKey(nameof(Employee))]
        [DisplayName("Personel")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey(nameof(Project))]
        [DisplayName("Proje")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
