using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("coso")]
    public class coso
    {
        
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Column("id")]
            public int Id { set; get; }

            [StringLength(50)]
            [Column("Name")]
            public string Name { set; get; }
            [Column("Loaicoso")]
            public int Loaicoso { set; get; }
            [Column("Thoigianvanhanh")]
            public int Thoigianvanhanh { set; get; }
        
    }
}
