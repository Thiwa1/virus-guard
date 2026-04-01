using System;

namespace VirusGuard.Features
{
    public interface ISupportFeature { }

    public class ExpertVirusCheck : ISupportFeature
    {
        public void RequestSupport() => Console.WriteLine("Expert Virus Check & Removal: Remote IT support to remove viruses and fix existing issues.");
    }

    public class EasyManagement : ISupportFeature
    {
        public void OpenDashboard() => Console.WriteLine("Easy Management: Opening unified online account dashboard.");
    }
}
