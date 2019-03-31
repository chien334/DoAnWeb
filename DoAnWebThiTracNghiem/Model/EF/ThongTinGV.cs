namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinGV")]
    public partial class ThongTinGV
    {
        [Key]
        [StringLength(8)]
        public string MaGV { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(13)]
        public string DienThoai { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string NoiSinh { get; set; }

        [Required]
        [StringLength(30)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(30)]
        public string DanToc { get; set; }

        [Required]
        [StringLength(30)]
        public string TonGiao { get; set; }

        [Required]
        public string HinhAnh { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
