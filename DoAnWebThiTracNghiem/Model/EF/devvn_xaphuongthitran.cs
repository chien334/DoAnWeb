namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class devvn_xaphuongthitran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public devvn_xaphuongthitran()
        {
            DiaChis = new HashSet<DiaChi>();
        }

        [Key]
        [StringLength(5)]
        public string xaid { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string kieu { get; set; }

        [Required]
        [StringLength(3)]
        public string maqh { get; set; }

        public virtual devvn_quanhuyen devvn_quanhuyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaChi> DiaChis { get; set; }
    }
}
