namespace MVC3Tests.Models
{
    public class Fund
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long ManagerID { get; set; }
        public long StrategyID { get; set; }
    }
}