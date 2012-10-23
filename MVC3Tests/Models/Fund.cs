using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace MVC3Tests.Models
{
    [Bind(Exclude = "ID")]
    [Table("Fund")]
    public class Fund
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Funds must have a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Funds must have a code.")]
        [StringLength(10)]
        public string Code { get; set; }
        [DisplayName("Manager")]
        public int ManagerID { get; set; }
        [DisplayName("Strategy")]
        public int StrategyID { get; set; }

        public virtual Strategy Strategy { get; set; }
        public virtual Manager Manager { get; set; }
    }
}