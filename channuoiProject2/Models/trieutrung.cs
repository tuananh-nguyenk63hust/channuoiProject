﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace channuoiProject2
{
    [Table("trieutrung")]
    public class trieutrung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int Giasuc { get; set; }
        public string Trieutrung { get; set; }
        public int DichBenhId { get; set; } 
    }
}
