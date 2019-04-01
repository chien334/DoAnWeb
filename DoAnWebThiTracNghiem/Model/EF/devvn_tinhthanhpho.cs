namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class devvn_tinhthanhpho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public devvn_tinhthanhpho()
        {
            devvn_quanhuyen = new HashSet<devvn_quanhuyen>();
            DiaChis = new HashSet<DiaChi>();
            ThongTinGVs = new HashSet<ThongTinGV>();
            ThongTinHS = new HashSet<ThongTinH>();
        }

        [Key]
        [StringLength(2)]
        public string matp { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string kieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<devvn_quanhuyen> devvn_quanhuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinGV> ThongTinGVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinH> ThongTinHS { get; set; }
    }
}
