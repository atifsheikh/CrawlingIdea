using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Crawler
{
    public class Variables
    {
        public static Task task;
        public static TaskScheduler UISyncContext;
        public static string DB_Connection_url = "http://46.21.99.218:8080";//46.21.102.136:82";//"http://atif-pc:8080";//http://46.21.99.218:8080";//atif-pc:8080"; // 109.74.12.196:82//http://atif-pc:8080"
        public static string DB_Connection_url_Path = DB_Connection_url  + "/databases/";
        public static string DatabaseName = "onekey";
        public static string DB_Connection = DB_Connection_url_Path + DatabaseName;//also modify in web.config (MvcApplication1)
        public const string CallbackUrl = "http://46.21.102.136:85/";


        public static string FoundCategoryPage { get; set; }

        public static string FoundMessagesPage { get; set; }

        public static string URL_firstpart { get; set; }
    }
}
