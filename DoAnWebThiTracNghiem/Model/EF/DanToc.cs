namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanToc")]
    public partial class DanToc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanToc()
        {
            ThongTinGVs = new HashSet<ThongTinGV>();
            ThongTinHS = new HashSet<ThongTinH>();
        }

        [Key]
        [StringLength(2)]
        public string MaDT { get; set; }

        [Required]
        [StringLength(20)]
        public string TenDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinGV> ThongTinGVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinH> ThongTinHS { get; set; }
    }
}
