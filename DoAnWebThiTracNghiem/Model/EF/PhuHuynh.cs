namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhuHuynh")]
    public partial class PhuHuynh
    {
        [Key]
        public int MaPH { get; set; }

        [Required]
        [StringLength(8)]
        public string MaHS { get; set; }

        [Required]
        [StringLength(30)]
        public string TenQuanHe { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTenPH { get; set; }

        [Required]
        [StringLength(100)]
        public string NgheNghiep { get; set; }

        [Required]
        [StringLength(13)]
        public string DienThoai { get; set; }

        public virtual HocSinh HocSinh { get; set; }
    }
}
