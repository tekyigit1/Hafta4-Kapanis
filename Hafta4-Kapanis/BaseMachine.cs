namespace TechStoreProject
{
    public class BaseMachine
    {
        public string ProductionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public virtual void ProductInfo()
        {
            Console.WriteLine($"Device: {Name}, Serial: {SerialNumber}, OS: {OperatingSystem}");
        }
    }
}
