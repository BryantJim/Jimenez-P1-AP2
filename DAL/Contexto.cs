using Microsoft.EntityFrameworkCore;

namespace Jimenez_P1_AP2.DAL
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= Data\Parcial.db");
        }
    }
}