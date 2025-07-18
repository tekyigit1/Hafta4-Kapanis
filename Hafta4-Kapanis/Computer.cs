namespace TechStoreProject
{
    public class Computer : BaseMachine
    {
        public bool HasBluetooth { get; set; }

        public override void ProductInfo()
        {
            Console.WriteLine($"Computer: {Name}, Bluetooth: {HasBluetooth}, OS: {OperatingSystem}");
        }
    }
}
