using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace channuoiProject2
{
    [Table("vaccin")]
    public class vaccin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int VaccinId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Giasuc { get; set; }
    }
}
