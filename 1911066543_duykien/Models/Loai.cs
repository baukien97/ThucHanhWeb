namespace _1911066543_duykien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loai")]
    public partial class Loai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maloai { get; set; }

        [StringLength(30)]
        public string tenloai { get; set; }
    }
}
