namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeThi")]
    public partial class DeThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeThi()
        {
            HocSinhDeThis = new HashSet<HocSinhDeThi>();
            CauHois = new HashSet<CauHoi>();
        }

        [Key]
        public int MaDe { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDe { get; set; }

        [StringLength(8)]
        public string MaGV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaMH { get; set; }

        public int ThoiGian { get; set; }

        public DateTime NgayThi { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocSinhDeThi> HocSinhDeThis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauHoi> CauHois { get; set; }
    }
}
