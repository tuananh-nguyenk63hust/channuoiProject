using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("tiemphong")]
    public class tiemphong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int VaccinId { get; set; }
        public int OdichId { get; set; }
        [StringLength(50)]
        public string VaccinName { get; set; }  
        public int Thoigiantiem { get; set; }
        public int Soluongdatiem { get; set; }
        public int Soluongchuatien { get; set; }
    }
}
