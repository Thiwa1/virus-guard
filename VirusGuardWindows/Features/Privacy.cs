namespace VirusGuardWindows.Features
{
    public interface IPrivacyFeature { }

    public class VpnService : IPrivacyFeature
    {
        public string Connect() => "VPN Service: Encrypting data and masking IP address.";
        public string ConnectPremium() => "VPN Service (Premium): Connecting to unlimited & fast VPN.";
    }

    public class WebcamProtection : IPrivacyFeature
    {
        public string MonitorAccess() => "Webcam and Microphone Protection: Monitoring and blocking unauthorized access.";
    }

    public class PrivateBrowsing : IPrivacyFeature
    {
        public string Enable() => "Private Browsing: Preventing tracking from websites and social networks.";
    }

    public class DataLeakChecker : IPrivacyFeature
    {
        public string Scan() => "Data Leak Checker: Scanning websites and Dark Web for leaked personal data.";
    }

    public class PasswordManager : IPrivacyFeature
    {
        public string SyncVault() => "Password Manager & Vault: Syncing and generating strong passwords safely.";
    }

    public class StalkerwareDetection : IPrivacyFeature
    {
        public string Detect() => "Stalkerware Detection: Warning against apps trying to track activity.";
    }
}
