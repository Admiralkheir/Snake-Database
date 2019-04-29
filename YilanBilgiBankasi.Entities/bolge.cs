namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bolge")]
    public partial class bolge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bolge()
        {
            ils = new HashSet<il>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte bolgeID { get; set; }

        [StringLength(20)]
        public string bolgeAd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<il> ils { get; set; }
    }
}
