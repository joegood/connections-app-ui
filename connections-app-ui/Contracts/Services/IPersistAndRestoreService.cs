namespace connections_app_ui.Contracts.Services;

public interface IPersistAndRestoreService
{
    void RestoreData();

    void PersistData();
}
