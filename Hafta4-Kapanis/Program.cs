using System;

namespace TechStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Kullanıcı hayır demediği sürece döngü devam eder
            {
                Console.WriteLine("Press 1 to create a Phone, or 2 to create a Computer:");
                // Kullanıcıdan ürün tipi seçmesi istenir
                string choice = Console.ReadLine();

                BaseMachine device = null; // Ortak sınıftan bir nesne oluşturulur

                if (choice == "1")
                {
                    // Telefon nesnesi oluşturuluyor
                    device = new Phone()
                    {
                        Name = "Galaxy S24",
                        SerialNumber = "P123456",
                        OperatingSystem = "Android",
                        Description = "Latest model",
                        ProductionDate = "2025-07-18",
                        SimCardCount = 2
                    };
                }
                else if (choice == "2")
                {
                    // Bilgisayar nesnesi oluşturuluyor
                    device = new Computer()
                    {
                        Name = "MacBook Pro",
                        SerialNumber = "C654321",
                        OperatingSystem = "macOS",
                        Description = "Powerful laptop",
                        ProductionDate = "2025-07-18",
                        HasBluetooth = true
                    };
                }
                else
                {
                    // Geçersiz seçim yapıldığında uyarı verir
                    Console.WriteLine("Invalid input. Please try again.");
                    continue; // Döngü başına geri dön
                }

                // Ürün bilgileri ekrana yazdırılır (polymorphism uygulanır)
                device.ProductInfo();

                // Yeni bir ürün daha oluşturmak isteyip istemediği sorulur
                Console.WriteLine("Do you want to create another product? (yes/no):");
                string answer = Console.ReadLine().ToLower();

                if (answer != "yes")
                {
                    // Kullanıcı 'hayır' derse uygulama kapanır
                    Console.WriteLine("Have a nice day!");
                    break; // Döngüden çık
                }

                Console.Clear(); // Ekran temizlenir (isteğe bağlı)
            }
        }
    }
}

