using connections_app_ui.Core.Models;

namespace connections_app_ui.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();
}
