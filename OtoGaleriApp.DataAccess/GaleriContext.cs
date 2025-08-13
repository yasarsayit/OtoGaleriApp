using System.Data.Entity;
using System.Reflection.Emit;
using OtoGaleriApp.Model; 
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace OtoGaleriApp.DataAccess
{
    public class GaleriContext : DbContext
    {
        public GaleriContext() : base("name=GaleriDb")
        {
            
            Database.SetInitializer(new CreateDatabaseIfNotExists<GaleriContext>());
        }

        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Satis> Satislar { get; set; }


protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Satis>()
            .HasRequired(s => s.Satici)
            .WithMany()
            .HasForeignKey(s => s.SaticiId)
            .WillCascadeOnDelete(false); // OnDelete yerine

        modelBuilder.Entity<Satis>()
            .HasRequired(s => s.Alici)
            .WithMany()
            .HasForeignKey(s => s.AliciId)
            .WillCascadeOnDelete(false);
    }


}


}
