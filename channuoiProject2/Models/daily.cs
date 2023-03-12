using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("daily")]
    public class daily
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Loaidaily { get; set; }
        public int Thoigianvanhanh { get; set; }
    }
}
