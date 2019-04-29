namespace YilanBilgiBankasi.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using YilanBilgiBankasi.Entities;

    public partial class YilanDBContext : DbContext
    {
        public YilanDBContext()
            : base("name=YilanDBContext")
        {
        }

        public virtual DbSet<besinler> besinlers { get; set; }
        public virtual DbSet<biyotop> biyotops { get; set; }
        public virtual DbSet<bolge> bolges { get; set; }
        public virtual DbSet<il> ils { get; set; }
        public virtual DbSet<yilanAile> yilanAiles { get; set; }
        public virtual DbSet<yilanCin> yilanCins { get; set; }
        public virtual DbSet<yilanEpidet> yilanEpidets { get; set; }
        public virtual DbSet<yilanlar> yilanlars { get; set; }
        public virtual DbSet<yilanRenk> yilanRenks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<besinler>()
                .HasMany(e => e.yilanlars)
                .WithMany(e => e.besinlers)
                .Map(m => m.ToTable("yilanBesin").MapLeftKey("besinID").MapRightKey("yilanID"));

            modelBuilder.Entity<biyotop>()
                .HasMany(e => e.yilanlars)
                .WithMany(e => e.biyotops)
                .Map(m => m.ToTable("turBiyotop").MapLeftKey("biyotopID").MapRightKey("yilanID"));

            modelBuilder.Entity<il>()
                .Property(e => e.ilAd)
                .IsFixedLength();

            modelBuilder.Entity<il>()
                .HasMany(e => e.yilanlars)
                .WithMany(e => e.ils)
                .Map(m => m.ToTable("yilanIl").MapLeftKey("ilID").MapRightKey("yilanID"));

            modelBuilder.Entity<yilanAile>()
                .HasMany(e => e.yilanCins)
                .WithOptional(e => e.yilanAile)
                .WillCascadeOnDelete();

            modelBuilder.Entity<yilanCin>()
                .Property(e => e.yilanCinsi)
                .IsFixedLength();

            modelBuilder.Entity<yilanCin>()
                .HasMany(e => e.yilanlars)
                .WithOptional(e => e.yilanCin)
                .WillCascadeOnDelete();

            modelBuilder.Entity<yilanlar>()
                .Property(e => e.bilinenAd)
                .IsUnicode(false);

            modelBuilder.Entity<yilanlar>()
                .HasMany(e => e.yilanRenks)
                .WithMany(e => e.yilanlars)
                .Map(m => m.ToTable("turRenk").MapLeftKey("yilanID").MapRightKey("yilanRenkID"));

            modelBuilder.Entity<yilanRenk>()
                .Property(e => e.yilanRenk1)
                .IsUnicode(false);
        }
    }
}
