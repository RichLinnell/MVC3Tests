using System.ComponentModel.DataAnnotations.Schema;

namespace MVC3Tests.Models
{
    [Table("Strategy")]
    public class Strategy
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}