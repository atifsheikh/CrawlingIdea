using OneKey.Crawler;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.Config
{
    public class Category : ConfigConcept
    {
        public Forum Forum { get; set; }
        public string Title { get; set; }
        public Int16 Level { get; set; }
        public Int16 MessageCount { get; set; }
        public Int16 ThereadCount { get; set; }
        public Int16 PageCount { get; set; }
        public bool Subscribed { get; set; }
        public Int16 LastCrawledPage { get; set; }

        public static IEnumerable<Category> GetAll(Int64 id)
        {
            try
            {
                IEnumerable<Category> result = new QueryResultRows<Category>();
                DbSession dbs = new DbSession();
                dbs.RunAsync(() =>
                {
                    result = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.Forum.Id = ?", id);
                    // Do something with p here.
                }, 3);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Category Get(Int64 id)
        {
            return Db.SQL<OneKey.Database.Config.Category>("SELECT f FROM OneKey.Database.Config.Category f WHERE f.Id =?", id).First;
        }

        //public static Category Get(string ForumName)
        //{
        //    return Db.SQL<OneKey.Database.Config.Category>("SELECT f FROM OneKey.Database.Config.Category f WHERE f.Name =?", CategoryName).First;
        //}

        public static void Set(Category inout_Item)
        {
            Db.Transaction(() =>
            {
                Category _CategoryCommit = inout_Item;
            });
        }

        public static bool Exists(short Id)
        {
            if (Db.SQL<OneKey.Database.Config.Category>("SELECT f FROM OneKey.Database.Config.Category f WHERE f.Id=?", Id).First != null)
                return true;
            else
                return false;

        }

        public static void Update(Category inout_Item)
        {
            Set(inout_Item);						// just alias for now
        }

        public static void Delete(short id)
        {
            //using (var se = _session.Invoke())
            //{
            //    var f = se.Query<Model.NoSql.Category>().FirstOrDefault(f1 => f1.Id == id);
            //    se.Delete<Model.NoSql.Category>(f);
            //    se.SaveChanges();
            //}
        }

    }
}
