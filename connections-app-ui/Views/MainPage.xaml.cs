using System.Windows.Controls;

using connections_app_ui.ViewModels;

namespace connections_app_ui.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
