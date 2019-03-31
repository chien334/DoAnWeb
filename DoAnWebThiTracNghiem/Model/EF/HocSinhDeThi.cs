namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinhDeThi")]
    public partial class HocSinhDeThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinhDeThi()
        {
            LuaChons = new HashSet<LuaChon>();
        }

        [Key]
        public int MaBT { get; set; }

        [Required]
        [StringLength(8)]
        public string MaHS { get; set; }

        public int MaDe { get; set; }

        public int ThoiGianLam { get; set; }

        public int LanThi { get; set; }

        public double Diem { get; set; }

        public virtual DeThi DeThi { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LuaChon> LuaChons { get; set; }
    }
}
