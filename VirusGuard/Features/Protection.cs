using System;

namespace VirusGuard.Features
{
    public interface IProtectionFeature { }

    public class RealTimeAntivirus : IProtectionFeature
    {
        public void Scan() => Console.WriteLine("Real-Time Antivirus: Scanning files, applications, and websites for malware.");
    }

    public class AntiRansomware : IProtectionFeature
    {
        public void Monitor() => Console.WriteLine("Anti-Ransomware: Monitoring for suspicious ransomware activity.");
    }

    public class TwoWayFirewall : IProtectionFeature
    {
        public void ManageTraffic() => Console.WriteLine("Two-Way Firewall: Managing incoming and outgoing network requests.");
    }

    public class MaliciousLinkDetector : IProtectionFeature
    {
        public void CheckUrl(string url) => Console.WriteLine($"Malicious Link Detector: Checking URL {url} against Kaspersky Security Network.");
    }

    public class ApplicationControl : IProtectionFeature
    {
        public void VerifyApp(string appName) => Console.WriteLine($"Application Control: Verifying if {appName} is a trusted application.");
    }

    public class EmergencyRecovery : IProtectionFeature
    {
        public void Recover() => Console.WriteLine("Emergency Recovery: Initiating malware removal and system restoration.");
    }
}
