using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("luatphap")]
    public class luatphap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Loaigiayto { get; set; } 
        
    }
}
