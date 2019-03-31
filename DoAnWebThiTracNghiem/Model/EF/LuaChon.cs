namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuaChon")]
    public partial class LuaChon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LuaChon()
        {
            HocSinhDeThis = new HashSet<HocSinhDeThi>();
        }

        [Key]
        public int MaLuaChon { get; set; }

        [Required]
        public string NoiDung { get; set; }

        public bool LaDapAn { get; set; }

        public int MaCauHoi { get; set; }

        public virtual CauHoi CauHoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocSinhDeThi> HocSinhDeThis { get; set; }
    }
}
