using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.Config
{
    public class Thread : Category
    {
        public Category Category;
        public Int64 FirstMessageId{ get; set; }
        public Int64 LastMessageId{ get; set; }
        public string LastAuthor { get; set; }
        public string Author{ get; set; }

        public static QueryResultRows<OneKey.Database.Config.Thread> GetAll(short parentEntity)
        {
            return Db.SQL<OneKey.Database.Config.Thread>("SELECT f FROM OneKey.Database.Config.Thread f");
        }

        public static Thread Get(long id)
        {
            return Db.SQL<OneKey.Database.Config.Thread>("SELECT f FROM OneKey.Database.Config.Thread f WHERE f.Id =?", id).First;
        }

        public static Thread Get(string ThreadName)
        {
            return Db.SQL<OneKey.Database.Config.Thread>("SELECT f FROM OneKey.Database.Config.Thread f WHERE f.Name =?", ThreadName).First;
        }

        public static void Set(Thread inout_Item)
        {
            Db.Transaction(() =>
            {
                Thread _ThreadCommit = inout_Item;
            });
        }

        public static bool Exists(short Id)
        {
            if (Db.SQL<OneKey.Database.Config.Thread>("SELECT f FROM OneKey.Database.Config.Thread f WHERE f.Id=?", Id).First != null)
                return true;
            else
                return false;
        }

        public static Thread Get(Int32 item, long forum)
        {
            try
            {

                    var thread = Db.SQL<OneKey.Database.Config.Thread>("SELECT t FROM OneKey.Database.Config.Thread t WHERE t.ExternalId = ? AND t.ForumId =?",  item, forum).First;
                    return thread;
            }
            catch (Exception) // Happens sometimes with overloaded indexes - wait for them to update.
            {
                System.Threading.Thread.Sleep(5000);
                return null;
            }

        }

        public static Thread Get(string item, long forum)
        {
            try
            {
                return Db.SQL<OneKey.Database.Config.Thread>("SELECT t FROM OneKey.Database.Config.Thread WHERE t.StringExternalId = ? AND t.ForumId =? ", item , forum).First;
            }
            catch (Exception) // Happens sometimes with overloaded indexes - wait for them to update.
            {
                //System.Threading.Thread.Sleep(5000);
                return null;
            }

        }

        public static bool Exsist(string item, long forum, ref Thread out_Item)//, string StringItem
        {
            int resultIntItem = 0;
            int.TryParse(item, out resultIntItem);
            if (resultIntItem == 0)
            {
                // TODO: more lightweight implementation that does not read actual object from base
                out_Item = Get(item, forum);
                return (out_Item != null);
            }
            else
            {
                // TODO: more lightweight implementation that does not read actual object from base
                out_Item = Get((short)resultIntItem, forum);
                return (out_Item != null);
            }
        }

        public static void Update(Thread inout_Item)
        {
            Set(inout_Item);						// just alias for now
        }

        public static void Delete(short id)
        {
            //using (var se = _session.Invoke())
            //{
            //    var f = se.Query<Model.NoSql.Thread>().FirstOrDefault(f1 => f1.Id == id);
            //    se.Delete<Model.NoSql.Thread>(f);
            //    se.SaveChanges();
            //}
        }

    }
}
