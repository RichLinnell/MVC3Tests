using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVC3Tests.Models
{
    [Bind(Exclude = "ID")]
    public class Fund
    {
        [ScaffoldColumn(false)]
        public long ID { get; set; }
        [Required(ErrorMessage = "Funds must have a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Funds must have a code.")]
        [StringLength(10)]
        public string Code { get; set; }
        [DisplayName("Manager")]
        public long ManagerID { get; set; }
        [DisplayName("Strategy")]
        public long StrategyID { get; set; }
    }
}