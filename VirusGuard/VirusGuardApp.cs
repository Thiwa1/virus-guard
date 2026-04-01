using System;
using VirusGuard.Models;
using VirusGuard.Features;

namespace VirusGuard
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
            Console.WriteLine($"\n--- VirusGuard Initialized with {CurrentPlan} Plan ---");
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

        public void RunSystemScan()
        {
            Console.WriteLine("\nStarting System Scan...");
            Antivirus?.Scan();
            Optimizer?.Optimize();

            if (CurrentPlan >= Plan.Plus)
            {
                LeakChecker?.Scan();
            }

            if (CurrentPlan == Plan.Premium)
            {
                HomeMonitor?.MonitorNetwork();
            }
            Console.WriteLine("Scan Complete.\n");
        }
    }
}
