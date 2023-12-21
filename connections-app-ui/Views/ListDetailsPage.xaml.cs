using System.Windows.Controls;

using connections_app_ui.ViewModels;

namespace connections_app_ui.Views;

public partial class ListDetailsPage : Page
{
    public ListDetailsPage(ListDetailsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
