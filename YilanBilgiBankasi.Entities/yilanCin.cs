namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yilanCins")]
    public partial class yilanCin
    {
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yilanCin()
        {
            yilanlars = new HashSet<yilanlar>();
        }

        [Key]
        public short yilanCinsID { get; set; }

        public short? yilanAileID { get; set; }

        [StringLength(15)]
        public string yilanCinsi { get; set; }

        public virtual yilanAile yilanAile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yilanlar> yilanlars { get; set; }
    }
}
