using System;
using System.Windows;
using System.Windows.Controls;
using VirusGuardWindows.Models;

namespace VirusGuardWindows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppendOutput("System Ready. Please select a plan and run a scan.");
        }

        private void RunScanButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlanSelector.SelectedItem is ComboBoxItem selectedItem)
            {
                string planString = selectedItem.Content.ToString() ?? "Standard";
                Plan selectedPlan = (Plan)Enum.Parse(typeof(Plan), planString);

                var app = new VirusGuardApp(selectedPlan);
                string scanResults = app.RunSystemScan();

                OutputTextBlock.Text = ""; // Clear previous output
                AppendOutput(scanResults);
            }
        }

        private void AppendOutput(string text)
        {
            OutputTextBlock.Text += text + "\n";
        }
    }
}
