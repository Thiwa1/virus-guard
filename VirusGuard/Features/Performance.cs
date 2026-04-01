using System;

namespace VirusGuard.Features
{
    public interface IPerformanceFeature { }

    public class PerformanceOptimization : IPerformanceFeature
    {
        public void Optimize() => Console.WriteLine("Performance Optimization: Boosting PC speed and startup time.");
    }

    public class GamerMode : IPerformanceFeature
    {
        public void Activate() => Console.WriteLine("Gamer Mode: Suppressing notifications and pausing scans.");
    }

    public class HardDriveHealthMonitor : IPerformanceFeature
    {
        public void CheckHealth() => Console.WriteLine("Hard Drive Health Monitor: Checking temperature and performance of hard drives.");
    }

    public class DeviceSpaceCleanup : IPerformanceFeature
    {
        public void Cleanup() => Console.WriteLine("Device Space Cleanup: Removing unused apps and large/duplicate files.");
    }

    public class AppManagement : IPerformanceFeature
    {
        public void Manage() => Console.WriteLine("App Management: Suggesting updates or deletions for installed applications.");
    }
}
