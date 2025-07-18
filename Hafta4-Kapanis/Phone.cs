namespace TechStoreProject
{
    public class Phone : BaseMachine
    {
        public int SimCardCount { get; set; }

        public override void ProductInfo()
        {
            Console.WriteLine($"Phone: {Name}, SIMs: {SimCardCount}, OS: {OperatingSystem}");
        }
    }
}
