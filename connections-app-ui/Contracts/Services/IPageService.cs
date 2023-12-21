using System.Windows.Controls;

namespace connections_app_ui.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
