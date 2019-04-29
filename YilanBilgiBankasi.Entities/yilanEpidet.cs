namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yilanEpidet")]
    public partial class yilanEpidet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yilanEpidet()
        {
            yilanlars = new HashSet<yilanlar>();
        }

        public short yilanEpidetID { get; set; }

        [StringLength(20)]
        public string epidetAd { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yilanlar> yilanlars { get; set; }
    }
}
