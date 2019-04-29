namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("il")]
    public partial class il
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public il()
        {
            yilanlars = new HashSet<yilanlar>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ilID { get; set; }

        public byte? bolgeID { get; set; }

        [StringLength(15)]
        public string ilAd { get; set; }

        public virtual bolge bolge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yilanlar> yilanlars { get; set; }
    }
}
