using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("dichbenh")]
    public class dichbenh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DichbenhId { get; set; }
        [StringLength(50)]
        public string DichbenhName { get; set; }
        public int GiaSuc { get; set; }
        public int VaccinId { get; set; }
    }
}
