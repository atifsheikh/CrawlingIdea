using OneKey.Database;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Server.Handlers
{
    class DemoHooks
    {
        internal static void Init()
        {
            Handle.GET("/OneKeyDemo/SetupOneKey", () =>
            {
                Db.Transact(() =>
                {
                    WebPublication webPublication = new WebPublication();
                    webPublication.Name = "Cochranvw";
                    webPublication.Url = "https://www.cochranvw.com";
                    webPublication.Description = "Car Dealer";

                    ExternalFeature externalFeature = new ExternalFeature();
                    externalFeature.Name = "CrawlNewCars";
                    externalFeature.Site = webPublication;

                    ExternalAction externalAction = new ExternalAction();
                    externalAction.Name = "Crawl Urls & Data";
                    externalAction.ActionUrl = "http://www.cochranvw.com/VehicleSearchResults?search=new";
                    externalAction.HttpBody = "";
                    externalAction.HttpType = "GET";
                    externalAction.OrderInFeature = 0;
                    externalAction.Pagging = true;
                    externalAction.PaggingUrlParameters = "&pageNumber={0}";
                    externalAction.Feature = externalFeature;

                    ExternalVariable externalVariable = new ExternalVariable();
                    externalVariable.Name = "<<WebResource>>";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "<a data-window-pixel=\"vsr_title\"  href=\"(.*?)\" itemprop=\"url";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "listing_url";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "<a data-window-pixel=\"vsr_title\"  href=\"(.*?)\" itemprop=\"url";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "vehicles_trim";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "itemprop=\"trim\"[^>]+>(.*?)</span>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "vehicles_model";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "itemprop=\"model\"[^>]+>(.*?)</span>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "vehicles_make";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "itemprop=\"manufacturer\"[^>]+>(.*?)</span>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "vehicles_year";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "itemprop=\"releaseDate\"[^>]+>(\\d*)</span>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "vehicles_price";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "itemprop=\"price\"[^>]+value=\"(.*?)\"";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;
                });


                Db.Transact(() => 
                {
                    WebPublication webPublication = new WebPublication();
                    webPublication.Name = "Flashback";
                    webPublication.Url = "https://www.flashback.org";
                    webPublication.Description = "Swedish Forum";

                    ExternalFeature externalFeature = new ExternalFeature();
                    externalFeature.Name = "Session";
                    externalFeature.Site = webPublication;

                    ExternalAction externalAction = new ExternalAction();
                    externalAction.Name = "GetCookies";
                    externalAction.ActionUrl = "https://www.flashback.org/login.php";
                    externalAction.HttpBody = "";
                    externalAction.HttpType = "POST";
                    externalAction.OrderInFeature = 0;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    externalAction = new ExternalAction();
                    externalAction.Name = "Login";
                    externalAction.ActionUrl = "https://www.flashback.org/login.php";
                    externalAction.HttpBody = "vb_login_username={0}&vb_login_password=&do=login&vb_login_md5password**={1}&vb_login_md5password_utf={1}";
                    externalAction.HttpType = "POST";
                    externalAction.OrderInFeature = 1;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    ExternalVariable externalVariable = new ExternalVariable();
                    externalVariable.Name = "SecurityToken";
                    externalVariable.VariableType = "Session";
                    externalVariable.Regex = "SECURITYTOKEN = \"(.*?)\";";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "SessionURL";
                    externalVariable.VariableType = "Session";
                    externalVariable.Regex = "SESSIONURL = \"s=(.*?)&\";";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "PostHash";
                    externalVariable.VariableType = "Session";
                    externalVariable.Regex = "\"posthash\":\"(.*?)\"";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalFeature = new ExternalFeature();
                    externalFeature.Name = "PostThread";
                    externalFeature.Site = webPublication;

                    externalAction = new ExternalAction();
                    externalAction.Name = "PostThread";
                    externalAction.ActionUrl = "https://www.flashback.org/newthread.php?do=newthread&f={0}";
                    externalAction.HttpBody = "subject={0}&message={1}.&wysiwyg=0&f={2}&do=postthread&posthash=&poststarttime=&loggedinuser={3}&s={4}&parseurl=1&emailupdate=9999&stoken=";
                    externalAction.HttpType = "POST";
                    externalAction.OrderInFeature = 0;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "StorePost";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "thread_lastview=.*?Bi-(\\d*)";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalFeature = new ExternalFeature();
                    externalFeature.Name = "PostReply";
                    externalFeature.Site = webPublication;

                    externalAction = new ExternalAction();
                    externalAction.Name = "PostReply";
                    externalAction.ActionUrl = "https://www.flashback.org/newreply.php?do=newreply&noquote=1&p={0}";
                    externalAction.HttpBody = "";
                    externalAction.HttpType = "POST";
                    externalAction.OrderInFeature = 0;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "StorePost";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "#p([\\d]{1,10})";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalFeature = new ExternalFeature();
                    externalFeature.Name = "Crawl";
                    externalFeature.Site = webPublication;

                    externalAction = new ExternalAction();
                    externalAction.Name = "CrawlCategory";
                    externalAction.ActionUrl = "https://www.flashback.org/f{0}p{1}";
                    externalAction.HttpBody = "";
                    externalAction.HttpType = "GET";
                    externalAction.OrderInFeature = 0;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "PageTitle";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "alt1Active td_forum\" id=\"f\\d*?\">\\s*?<div>\\s*?<a href=\"/f\\d*?\"><strong>(.*?)</strong>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "PageId";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "alt1Active td_forum\" id=\"f\\d*?\">\\s*?<div>\\s*?<a href=\"/f(\\d*?)\"><strong>.*?</strong>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalAction = new ExternalAction();
                    externalAction.Name = "CrawlThread";
                    externalAction.ActionUrl = "https://www.flashback.org/f{0}p{1}";
                    externalAction.HttpBody = "";
                    externalAction.HttpType = "GET";
                    externalAction.OrderInFeature = 1;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "PageTitle";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "thread_title_\\d*\">(.*?)<";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "PageId";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "thread_title_(\\d*)\">.*?<";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalAction = new ExternalAction();
                    externalAction.Name = "CrawlMessage";
                    externalAction.ActionUrl = "https://www.flashback.org/t{0}p{1}";
                    externalAction.HttpBody = "";
                    externalAction.HttpType = "GET";
                    externalAction.OrderInFeature = 2;
                    externalAction.Pagging = false;
                    externalAction.Feature = externalFeature;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "MessageId";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "post_message_(\\d*?)\">.*?</div>";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "MessageText";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "post_message_\\d*?\">(.*?)</tr>\\s*<tr>\\s*<td class=\"alt2 post-left-bottom\">";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "MessageUsername";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "(?:<a class=\"bigusername\" href=\".*?\">|post-user-avatar.*?<div class=\"post-user-info smallfont\" style=\"padding-top:5px\">\\s*<div>)((?<=^|>)[^><]+?(?=<|$))(?:</div>|<.*?post-user-avatar)";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;

                    externalVariable = new ExternalVariable();
                    externalVariable.Name = "MessageCreated";
                    externalVariable.VariableType = "Content";
                    externalVariable.Regex = "<div class=\"fl icon-post-old\"></div>[^\\w]+(.*?)[^\\w]*?<span";
                    externalVariable.VariableValue = "";
                    externalVariable.Action = externalAction;
                });
                return 200;
            });
        }
    }
}
