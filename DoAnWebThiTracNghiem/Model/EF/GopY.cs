namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GopY")]
    public partial class GopY
    {
        [Key]
        public int MaGopY { get; set; }

        [Required]
        [StringLength(8)]
        public string MaTK { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string NoiDung { get; set; }
    }
}
