using Microsoft.EntityFrameworkCore;

namespace UcakBiletiSitesi.Models
{
    public class HavayoluContext: DbContext
    {
        public DbSet<Yolcu> Yolcular { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database = Havayolu; Trusted_Connection = True");
        }
    }
}
