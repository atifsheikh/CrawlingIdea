using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.Config
{
    public class Forum: ConfigConcept
    {
        //public Int32 Id ;
        public string Type;
        //public int TimeZone ;
        public string Description;
        public string Region;
        public string Language;
        public string Culture;
        public string LoginUrl;
        public string PostThreadUrl;
        public string PostReplyUrl;
        public Int16 StartCrawlPage;
        public Int16 CrawlThreadPageInterval;
        public Int16 CrawlCategoryPageInterval;
        public bool StringExternalIdCategory;  //IsCategoryStringExternalId
        public bool StringExternalIdThread;     //IsThreadStringExternalId
        public string FixedCookies;
        public string Cookie1;
        public string Cookie2;
        public string Cookie3;
        public string Cookie4;
        public string PostAttribute1;
        public string PostAttribute2;
        public string LoginAttributes;
        public string PostThreadAttributes;
        public string PostReplyAttributes;
        public string PostQuoteAttributes;
        public string StorePostRegex;
        public string StoreThreadRegex;
        public string Origin;
        public string Encoding;

        public string UrlPage_Id;
        public string UrlPage_Title;

        public string CategoryPage_Url;
        public string CategoryPage_ThreadId;
        public string CategoryPage_ThreadTitle;

        public string ThreadPage_Url;
        public string ThreadPage_MessageCreated;
        public string ThreadPage_MessageId;
        public string ThreadPage_MessageText;
        public string ThreadPage_MessageUsername;

        public string TimeFormat;
        public string DateFormat;
        public string CrawlInterval;
        public Int16 MessageCount;

        public static QueryResultRows<OneKey.Database.Config.Forum> GetAll(short parentEntity)
        {            
            return Db.SQL<OneKey.Database.Config.Forum>("SELECT f FROM OneKey.Database.Config.Forum f");
        }

        public static Forum Get(long id)
        {
            try
            {
                return Db.SQL<OneKey.Database.Config.Forum>("SELECT f FROM OneKey.Database.Config.Forum f WHERE f.Id =?", id).First;
            }
            catch (Exception)
            { return null; }
        }

        public static Forum Get(string ForumName)
        {
            return Db.SQL<OneKey.Database.Config.Forum>("SELECT f FROM OneKey.Database.Config.Forum f WHERE f.Name =?", ForumName).First;
        }

        public static void Set(Forum inout_Item)
        {
            Db.Transaction(() => {
                Forum _ForumCommit = inout_Item;
            });
        }

        public static bool Exists(short Id)
        {
            if (Db.SQL<OneKey.Database.Config.Forum>("SELECT f FROM OneKey.Database.Config.Forum f WHERE f.Id=?", Id).First != null)
                return true;
            else 
                return false;

        }

        public static void Update(Forum inout_Item)
        {
            Set(inout_Item);						// just alias for now
        }

        public static void Delete(short id)
        {
            //using (var se = _session.Invoke())
            //{
            //    var f = se.Query<Model.NoSql.Forum>().FirstOrDefault(f1 => f1.Id == id);
            //    se.Delete<Model.NoSql.Forum>(f);
            //    se.SaveChanges();
            //}
        }

        //public static Forum? Get(short id, long forum) { throw new NotSupportedException(); }
        //public static Forum? Get(string id, long forum) { throw new NotSupportedException(); }
        //public static bool Exsist(string _, long __, ref Forum? ___) { throw new NotImplementedException(); }
        //public static bool Exsist(string _, ref Forum? ___) { throw new NotImplementedException(); }
    }
}