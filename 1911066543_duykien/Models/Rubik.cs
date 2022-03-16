namespace _1911066543_duykien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rubik")]
    public partial class Rubik
    {
        internal readonly decimal? Gia;

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string maloai { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ten { get; set; }

        public string mota { get; set; }

        [StringLength(50)]
        public string hang { get; set; }

        public decimal? gia { get; set; }

        [MaxLength(50)]
        public byte[] hinh { get; set; }

        public int? soluongton { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ngaycapnhat { get; set; }
    }
}
