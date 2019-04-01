namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaChi")]
    public partial class DiaChi
    {
        [Key]
        public int MaDC { get; set; }

        [Required]
        [StringLength(8)]
        public string MaHS { get; set; }

        public int MaLoai { get; set; }

        [Required]
        [StringLength(2)]
        public string TinhTP { get; set; }

        [Required]
        [StringLength(3)]
        public string QuanHuyen { get; set; }

        [Required]
        [StringLength(5)]
        public string PhuongXa { get; set; }

        [Required]
        [StringLength(300)]
        public string SoNha { get; set; }

        public virtual devvn_quanhuyen devvn_quanhuyen { get; set; }

        public virtual devvn_tinhthanhpho devvn_tinhthanhpho { get; set; }

        public virtual devvn_xaphuongthitran devvn_xaphuongthitran { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual LoaiDC LoaiDC { get; set; }
    }
}
