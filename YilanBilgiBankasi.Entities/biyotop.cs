namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("biyotop")]
    public partial class biyotop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public biyotop()
        {
            yilanlars = new HashSet<yilanlar>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte biyotopID { get; set; }

        [StringLength(40)]
        public string biyotopAd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yilanlar> yilanlars { get; set; }
    }
}
