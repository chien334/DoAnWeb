namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinh()
        {
            DiaChis = new HashSet<DiaChi>();
            HocSinhDeThis = new HashSet<HocSinhDeThi>();
            PhuHuynhs = new HashSet<PhuHuynh>();
            HoSoes = new HashSet<HoSo>();
        }

        [Key]
        [StringLength(8)]
        public string MaHS { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTenHS { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLop { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(9)]
        public string NienKhoa { get; set; }

        [Required]
        [StringLength(256)]
        public string PassWordHash { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocSinhDeThi> HocSinhDeThis { get; set; }

        public virtual Lop Lop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhuHuynh> PhuHuynhs { get; set; }

        public virtual ThongTinH ThongTinH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoSo> HoSoes { get; set; }
    }
}
