using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.Config
{
    public class Message : ConfigConcept
    {
        public Thread Thread;
        public string Text { get; set; }
        public string Author { get; set; }
        public Int16 Page { get; set; }



        public static Message Get(long id)
        {
                //var i = se.Query<Message>("MessageIndex").FirstOrDefault(m => m.Id == (int)id);
            return Db.SQL<OneKey.Database.Config.Message>("SELECT m FROM Message m WHERE m.Id = ?",(short)id).First;
        }
        public static Message Get(string StringExternalId)
        {
            return Db.SQL<OneKey.Database.Config.Message>("SELECT m FROM Message m WHERE m.StringExternalId = ?", StringExternalId).First;
        }
        public static Message Get(string id, long forum)
        {
            try
            {
                var i = Db.SQL<OneKey.Database.Config.Message>("SELECT m FROM Message m WHERE m.StringExternalId =? AND f.Forum.Id =?", id , forum);
                var MessageArray = i.ToList();
                if (i == null) return null;
                else if (MessageArray.Count() > 1)
                {
                    bool IgnoreFirstMessage = false;
                    foreach (Message _Message in MessageArray)
                    {
                        if (IgnoreFirstMessage == false)
                        {
                            IgnoreFirstMessage = true;
                            continue;
                        }
                        Delete((short)_Message.Id);
                    }
                }
                return i.FirstOrDefault(f => f.StringExternalId == id && f.Thread.Forum.Id == (short)forum);
            }
            catch (Exception) // Happens sometimes with overloaded indexes - wait for them to update.
            {
                //System.Threading.Thread.Sleep(5000);
                return null;
            }
            return null;
        }
        public static Message Get(short item, long _ThreadId)
        {
            try
            {
                 var i = Db.SQL<OneKey.Database.Config.Message>("SELECT m FROM Message m WHERE m.ExternalId =? AND m.ThreadId =?",item , _ThreadId);
                    var MessageArray = i.ToList();
                    if (i == null) return null;
                    else if (MessageArray.Count() > 1)
                    {
                        bool IgnoreFirstMessage = false;
                        foreach (Message _Message in MessageArray)
                        {
                            if (IgnoreFirstMessage == false)
                            {
                                IgnoreFirstMessage = true;
                                continue;
                            }
                            Delete((short)_Message.Id);
                        }
                    }
                    return i.FirstOrDefault(f => f.ExternalId == item && f.Thread.Id == _ThreadId);
            }
            catch (Exception) // Happens sometimes with overloaded indexes - wait for them to update.
            {
                //System.Threading.Thread.Sleep(5000);
                return null;
            }
            return null;
        }
        /// <summary>
        /// modify inout_Item: set proper Id of this message in DB if has not already
        /// </summary>
        /// <param name="inout_Item"></param>
        public static void Set(Message inout_Item)
        {
            Db.Transaction(() => {
                Message _MessageCommit = inout_Item;
            });
        }

        public static bool Exsist(string item, long thread, ref Message out_Item)
        {
            int resultIntItem = 0;
            int.TryParse(item, out resultIntItem);
            if (resultIntItem == 0)
            {
                // TODO: more lightweight implementation that does not read actual object from base
                out_Item = Get(item, thread);
                return (out_Item != null);
            }
            else
            {
                // TODO: more lightweight implementation that does not read actual object from base
                out_Item = Get((short)resultIntItem, thread);
                return (out_Item != null);
            }
        }


        public static bool Exsist(string StringExternalId, ref Message out_Item)
        {
            out_Item = Get(StringExternalId);
            return (out_Item != null);
        }

        public static void Update(Message inout_Item)
        {
            Set(inout_Item);		// just alias for now
        }

        public static void Delete(short id)
        {
            //{
            //    var MessageDocumentQuery = se.Query<NoSql.Message>("MessageIndex").Where(m => m.Id == id);

            //    se.Advanced.MaxNumberOfRequestsPerSession = 1073741000;
            //    se.Advanced.DocumentStore.DatabaseCommands.Delete("messages/" + id, null);
            //    //se.Delete(MessageDocumentQuery);
            //    //se.SaveChanges();
            //}
        }
    }
}
