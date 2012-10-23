using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace MVC3Tests.Models
{
    public class SystemEntities: DbContext
    {
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Strategy> Strategies { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}