using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace UcakBiletiSitesi.Models
{
    public class HavayoluContext: DbContext
    {
        public DbSet<Yolcu> Yolcular { get; set; }
        public DbSet<Havaalani> Havaalanlari { get; set; }
        public DbSet<Bilet> Biletler { get; set; }
        public DbSet<Ucus> Ucuslar { get; set; }
        public DbSet<Ucak> Ucaklar { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database = Havayolu; Trusted_Connection = True");
        }
    }
}
