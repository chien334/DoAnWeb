namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDC")]
    public partial class LoaiDC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDC()
        {
            DiaChis = new HashSet<DiaChi>();
        }

        [Key]
        public int MaLoai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChis { get; set; }
    }
}
