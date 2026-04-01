using System;
using VirusGuard.Models;
using VirusGuard.Features;

namespace VirusGuard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to VirusGuard Antivirus Solutions\n");

            // Simulate Standard Plan User
            var standardApp = new VirusGuardApp(Plan.Standard);
            standardApp.Antivirus?.Scan();
            standardApp.VPN?.Connect();

            // Note: Attempting to access Plus features like standardApp.LeakChecker would be null here and throw an exception if called directly without checking.
            Console.WriteLine("Data Leak Checker is available in Standard Plan: " + (standardApp.LeakChecker != null));


            // Simulate Plus Plan User
            var plusApp = new VirusGuardApp(Plan.Plus);
            plusApp.RunSystemScan();
            plusApp.VPN?.ConnectPremium();
            plusApp.Passwords?.SyncVault();
            plusApp.Webcam?.MonitorAccess();


            // Simulate Premium Plan User
            var premiumApp = new VirusGuardApp(Plan.Premium);
            premiumApp.RunSystemScan();
            premiumApp.ExpertSupport?.RequestSupport();

            Console.WriteLine("\nDemonstration complete. Press any key to exit.");
        }
    }
}
