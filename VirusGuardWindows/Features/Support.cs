namespace VirusGuardWindows.Features
{
    public interface ISupportFeature { }

    public class ExpertVirusCheck : ISupportFeature
    {
        public string RequestSupport() => "Expert Virus Check & Removal: Remote IT support to remove viruses and fix existing issues.";
    }

    public class EasyManagement : ISupportFeature
    {
        public string OpenDashboard() => "Easy Management: Opening unified online account dashboard.";
    }
}
