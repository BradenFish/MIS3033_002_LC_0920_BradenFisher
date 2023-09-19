using Microsoft.EntityFrameworkCore;

namespace a
{
    public class CityDB:DbContext
    {  
        public DbSet<City> cityTbl { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite("Data Source = city.db");
        }
    }
}