using Dating_App.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dating_App.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; }
    }
}