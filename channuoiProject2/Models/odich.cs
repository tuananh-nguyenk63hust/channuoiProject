using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("odich")]
    public class odich
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string OdichName { get; set; }
        [StringLength(50)]
        public string Vitri { get; set; }
        public int Giasuc { get; set; }
        public int Soluowng { get; set; }
    }
}
