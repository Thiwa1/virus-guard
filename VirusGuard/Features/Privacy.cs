using System;

namespace VirusGuard.Features
{
    public interface IPrivacyFeature { }

    public class VpnService : IPrivacyFeature
    {
        public void Connect() => Console.WriteLine("VPN Service: Encrypting data and masking IP address.");
        public void ConnectPremium() => Console.WriteLine("VPN Service (Premium): Connecting to unlimited & fast VPN.");
    }

    public class WebcamProtection : IPrivacyFeature
    {
        public void MonitorAccess() => Console.WriteLine("Webcam and Microphone Protection: Monitoring and blocking unauthorized access.");
    }

    public class PrivateBrowsing : IPrivacyFeature
    {
        public void Enable() => Console.WriteLine("Private Browsing: Preventing tracking from websites and social networks.");
    }

    public class DataLeakChecker : IPrivacyFeature
    {
        public void Scan() => Console.WriteLine("Data Leak Checker: Scanning websites and Dark Web for leaked personal data.");
    }

    public class PasswordManager : IPrivacyFeature
    {
        public void SyncVault() => Console.WriteLine("Password Manager & Vault: Syncing and generating strong passwords safely.");
    }

    public class StalkerwareDetection : IPrivacyFeature
    {
        public void Detect() => Console.WriteLine("Stalkerware Detection: Warning against apps trying to track activity.");
    }
}
