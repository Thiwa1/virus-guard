using System;

namespace VirusGuard.Features
{
    public interface ISpecializedFeature { }

    public class SafeMoney : ISpecializedFeature
    {
        public void SecureTransaction() => Console.WriteLine("Safe Money: Diverting to a secure, bank-grade browser for online payments.");
    }

    public class ParentalControls : ISpecializedFeature
    {
        public void Enforce() => Console.WriteLine("Parental Controls (Safe Kids): GPS tracking, screen time management, content filtering, and Safe Search.");
    }

    public class SmartHomeMonitor : ISpecializedFeature
    {
        public void MonitorNetwork() => Console.WriteLine("Smart Home Monitor: Identifying unknown devices on home Wi-Fi and optimizing it.");
    }
}
