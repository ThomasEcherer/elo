
namespace EloixClient.IndexServerFW.Utils
{
    public interface IListViewSettingsService
    {
        void ApplyVisibleColumns(System.Windows.Forms.ListView listView);
        void PersistVisibleColumns(System.Windows.Forms.ListView listView);
    }
}
