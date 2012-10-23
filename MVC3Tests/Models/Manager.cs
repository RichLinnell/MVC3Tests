using System.ComponentModel.DataAnnotations.Schema;

namespace MVC3Tests.Models
{
    [Table("Manager")]
    public class Manager
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}