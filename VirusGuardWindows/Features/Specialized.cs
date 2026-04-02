namespace VirusGuardWindows.Features
{
    public interface ISpecializedFeature { }

    public class SafeMoney : ISpecializedFeature
    {
        public string SecureTransaction() => "Safe Money: Diverting to a secure, bank-grade browser for online payments.";
    }

    public class ParentalControls : ISpecializedFeature
    {
        public string Enforce() => "Parental Controls (Safe Kids): GPS tracking, screen time management, content filtering, and Safe Search.";
    }

    public class SmartHomeMonitor : ISpecializedFeature
    {
        public string MonitorNetwork() => "Smart Home Monitor: Identifying unknown devices on home Wi-Fi and optimizing it.";
    }
}
