﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("tochucvacanhan")]
    public class tochucvacanhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Loaisanxuat { get; set; }    
        public int Thoigianvanhanh { get; set; }
    }
}
