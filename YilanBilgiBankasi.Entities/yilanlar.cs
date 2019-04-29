namespace YilanBilgiBankasi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("yilanlar")]
    public partial class yilanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public yilanlar()
        {
            biyotops = new HashSet<biyotop>();
            yilanRenks = new HashSet<yilanRenk>();
            ils = new HashSet<il>();
            besinlers = new HashSet<besinler>();
        }

        [Key]
        public short yilanID { get; set; }

        public short? yilanEpidetID { get; set; }

        public short? yilanCinsID { get; set; }

        [StringLength(30)]
        public string bilinenAd { get; set; }

        public short? ortalamaUzunluk { get; set; }

        public bool? zehirlilik { get; set; }
        [Column("yilanCins")]
        public virtual yilanCin yilanCin { get; set; }

        public virtual yilanEpidet yilanEpidet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<biyotop> biyotops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<yilanRenk> yilanRenks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<il> ils { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<besinler> besinlers { get; set; }
    }
}
