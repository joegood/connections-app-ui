using System.Windows.Controls;

using connections_app_ui.ViewModels;

namespace connections_app_ui.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
