using System;
using System.Text;
using VirusGuardWindows.Models;
using VirusGuardWindows.Features;

namespace VirusGuardWindows
{
    public class VirusGuardApp
    {
        public Plan CurrentPlan { get; private set; }

        // Core Features (Available in Standard and above)
        public RealTimeAntivirus? Antivirus { get; private set; }
        public VpnService? VPN { get; private set; }
        public PerformanceOptimization? Optimizer { get; private set; }

        // Plus Features
        public PasswordManager? Passwords { get; private set; }
        public DataLeakChecker? LeakChecker { get; private set; }
        public WebcamProtection? Webcam { get; private set; }

        // Premium Features
        public SmartHomeMonitor? HomeMonitor { get; private set; }
        public ExpertVirusCheck? ExpertSupport { get; private set; }

        public VirusGuardApp(Plan plan)
        {
            CurrentPlan = plan;
            InitializeFeatures();
        }

        private void InitializeFeatures()
        {
            // Standard Features
            Antivirus = new RealTimeAntivirus();
            VPN = new VpnService(); // Basic VPN
            Optimizer = new PerformanceOptimization();

            if (CurrentPlan >= Plan.Plus)
            {
                Passwords = new PasswordManager();
                LeakChecker = new DataLeakChecker();
                Webcam = new WebcamProtection();
                // Upgraded VPN behavior could be handled within the VpnService or by passing a flag
            }

            if (CurrentPlan == Plan.Premium)
            {
                HomeMonitor = new SmartHomeMonitor();
                ExpertSupport = new ExpertVirusCheck();
            }
        }

        public string RunSystemScan()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"--- VirusGuard System Scan ({CurrentPlan} Plan) ---");

            if (Antivirus != null) sb.AppendLine(Antivirus.Scan());
            if (Optimizer != null) sb.AppendLine(Optimizer.Optimize());

            if (CurrentPlan >= Plan.Plus)
            {
                if (LeakChecker != null) sb.AppendLine(LeakChecker.Scan());
                if (Webcam != null) sb.AppendLine(Webcam.MonitorAccess());
            }

            if (CurrentPlan == Plan.Premium)
            {
                if (HomeMonitor != null) sb.AppendLine(HomeMonitor.MonitorNetwork());
                if (ExpertSupport != null) sb.AppendLine(ExpertSupport.RequestSupport());
            }

            sb.AppendLine("--- Scan Complete ---");
            return sb.ToString();
        }
    }
}
