using Starcounter;

namespace OneKey.Server.Partials
{
    partial class ResultsView : Page
    {
        void Handle(Input.DeleteData Acion)
        {
            Db.Transact(() =>
            {
                Db.SlowSQL("DELETE FROM OneKey.Database.CrawlData.CrawlDataRow  WHERE WebPublication.Name=?", Acion.App.WebPublication);
            });

        }
    }
}
