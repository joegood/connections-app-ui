using System.Windows.Controls;

using connections_app_ui.Contracts.Views;
using connections_app_ui.ViewModels;

using MahApps.Metro.Controls;

namespace connections_app_ui.Views;

public partial class ShellWindow : MetroWindow, IShellWindow
{
    public ShellWindow(ShellViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    public Frame GetNavigationFrame()
        => shellFrame;

    public void ShowWindow()
        => Show();

    public void CloseWindow()
        => Close();
}
