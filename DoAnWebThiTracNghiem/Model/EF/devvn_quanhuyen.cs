namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class devvn_quanhuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public devvn_quanhuyen()
        {
            devvn_xaphuongthitran = new HashSet<devvn_xaphuongthitran>();
            DiaChis = new HashSet<DiaChi>();
        }

        [Key]
        [StringLength(3)]
        public string maqh { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string kieu { get; set; }

        [Required]
        [StringLength(2)]
        public string matp { get; set; }

        public virtual devvn_tinhthanhpho devvn_tinhthanhpho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<devvn_xaphuongthitran> devvn_xaphuongthitran { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChis { get; set; }
    }
}
