namespace VirusGuardWindows.Features
{
    public interface IProtectionFeature { }

    public class RealTimeAntivirus : IProtectionFeature
    {
        public string Scan() => "Real-Time Antivirus: Scanning files, applications, and websites for malware.";
    }

    public class AntiRansomware : IProtectionFeature
    {
        public string Monitor() => "Anti-Ransomware: Monitoring for suspicious ransomware activity.";
    }

    public class TwoWayFirewall : IProtectionFeature
    {
        public string ManageTraffic() => "Two-Way Firewall: Managing incoming and outgoing network requests.";
    }

    public class MaliciousLinkDetector : IProtectionFeature
    {
        public string CheckUrl(string url) => $"Malicious Link Detector: Checking URL {url} against Kaspersky Security Network.";
    }

    public class ApplicationControl : IProtectionFeature
    {
        public string VerifyApp(string appName) => $"Application Control: Verifying if {appName} is a trusted application.";
    }

    public class EmergencyRecovery : IProtectionFeature
    {
        public string Recover() => "Emergency Recovery: Initiating malware removal and system restoration.";
    }
}
