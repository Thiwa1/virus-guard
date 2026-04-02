namespace VirusGuardWindows.Features
{
    public interface IPerformanceFeature { }

    public class PerformanceOptimization : IPerformanceFeature
    {
        public string Optimize() => "Performance Optimization: Boosting PC speed and startup time.";
    }

    public class GamerMode : IPerformanceFeature
    {
        public string Activate() => "Gamer Mode: Suppressing notifications and pausing scans.";
    }

    public class HardDriveHealthMonitor : IPerformanceFeature
    {
        public string CheckHealth() => "Hard Drive Health Monitor: Checking temperature and performance of hard drives.";
    }

    public class DeviceSpaceCleanup : IPerformanceFeature
    {
        public string Cleanup() => "Device Space Cleanup: Removing unused apps and large/duplicate files.";
    }

    public class AppManagement : IPerformanceFeature
    {
        public string Manage() => "App Management: Suggesting updates or deletions for installed applications.";
    }
}
