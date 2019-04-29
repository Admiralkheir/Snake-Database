namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yilanRenk")]
    public partial class yilanRenk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yilanRenk()
        {
            yilanlars = new HashSet<yilanlar>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte yilanRenkID { get; set; }

        [Required]
        [StringLength(30)]
        public string yilanRenk1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yilanlar> yilanlars { get; set; }
    }
}
