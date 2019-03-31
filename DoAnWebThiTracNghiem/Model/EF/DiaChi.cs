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

        [Required]
        [StringLength(40)]
        public string TenDC { get; set; }

        [Required]
        [StringLength(30)]
        public string TinhTP { get; set; }

        [Required]
        [StringLength(30)]
        public string QuanHuyen { get; set; }

        [Required]
        [StringLength(30)]
        public string PhuongXa { get; set; }

        [Required]
        [StringLength(300)]
        public string SoNha { get; set; }

        public virtual HocSinh HocSinh { get; set; }
    }
}
