using ProjeYonetim.Entities.Constant;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int EmployeeId { get; set; }
        [DisplayName("Personel")]
        public Employee Employee { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        [DisplayName("Proje")]
        public Project Project { get; set; }
    }
}
