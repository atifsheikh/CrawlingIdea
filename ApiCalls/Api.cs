using Starcounter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.ApiCalls
{
    public class Api
    {
        //public static void Initiate()
        //{
        //    SetForum();
        //    GetForums();

        //}

        //public static void Init()
        //{
        //    try
        //    {
        //        Handle.GET("/Forums", () =>
        //        {
        //            var app = new ForumsPage();
        //            return app;
        //        });
        //    }
        //    catch (Exception ex)
        //    { }





        //}

        //private static void GetForums()
        //{
        //    try
        //    {
        //        Handle.GET("/GetForum", () =>
        //        {
        //            Forum f = Db.SQL<Forum>("SELECT F FROM Forum F").First;
        //            var json = new GetForum();
        //            json.Data =  f;
        //            return json;
        //        });
        //    }
        //    catch (Exception ex)
        //    { }
        //}

        //private static void SetForum()
        //{
        //    try
        //    {
        //        Handle.POST("/SetForums", (SetForums _Forums) =>
        //        {
        //            _Forums.Html = "/SetForums.html";
        //            _Forums.Forums = Db.SQL("SELECT i FROM Forum i");
        //            _Forums.Forum = Db.Scope<SetForum>(() =>
        //            {
        //                return new SetForum()
        //                {
        //                    Html = "/SetForum.html",
        //                    Data = new Forum()
        //                };
        //            });
        //            return _Forums;
        //        });




        //            //Forum q = Db.SQL<Forum>("SELECT f FROM Forum f WHERE Name=?", _Forum.Name).First;
        //            //if (q == null)
        //            //{
        //            //    Db.Transaction(() =>
        //            //    {
        //            //        var forum = new Forum()
        //            //        {
        //            //            Url = _Forum.Url,
        //            //            Updated = DateTime.Now,
        //            //            StringExternalId = "",
        //            //            LatestCrawlTime = DateTime.Now,
        //            //            ExternalId = 0,
        //            //            Created = DateTime.Now,
        //            //            Name = _Forum.Name,
        //            //            ForumType = _Forum.Type,
        //            //            Description = _Forum.Description,
        //            //            Region = _Forum.Region,
        //            //            Language = _Forum.Language,
        //            //            Culture = _Forum.Culture,
        //            //            LoginUrl = _Forum.LoginUrl,
        //            //            PostThreadUrl = _Forum.PostThreadUrl,
        //            //            PostReplyUrl = _Forum.PostReplyUrl,
        //            //            StartCrawlPage = long.Parse(_Forum.StartCrawlPage),
        //            //            CrawlCategoryPageInterval = long.Parse(_Forum.CrawlCategoryPageInterval),
        //            //            CrawlThreadPageInterval = long.Parse(_Forum.CrawlThreadPageInterval),
        //            //            IsCategoryStringExternalId = Convert.ToBoolean(Convert.ToInt32(_Forum.StringExternalIdCategory)),
        //            //            IsThreadStringExternalId = Convert.ToBoolean(Convert.ToInt32(_Forum.StringExternalIdThread)),
        //            //            FixedCookies = _Forum.FixedCookies,
        //            //            Cookie1 = _Forum.Cookie1,
        //            //            Cookie2 = _Forum.Cookie2,
        //            //            Cookie3 = _Forum.Cookie3,
        //            //            Cookie4 = _Forum.Cookie4,
        //            //            PostAttribute1 = _Forum.PostAttribute1,
        //            //            PostAttribute2 = _Forum.PostAttribute2,
        //            //            LoginAttributes = _Forum.LoginAttributes,
        //            //            PostThreadAttributes = _Forum.PostThreadAttributes,
        //            //            PostReplyAttributes = _Forum.PostReplyAttributes,
        //            //            PostQuoteAttributes = _Forum.PostQuoteAttributes,
        //            //            StorePostRegex = _Forum.StorePostRegex,
        //            //            StoreThreadRegex = _Forum.StoreThreadRegex,
        //            //            Origin = _Forum.Origin,
        //            //            Encoding = _Forum.Encoding,
        //            //            UrlPage_Id = _Forum.UrlPage_Id,
        //            //            UrlPage_Title = _Forum.UrlPage_Title,
        //            //            CategoryPage_Url = _Forum.CategoryPage_Url,
        //            //            CategoryPage_ThreadId = _Forum.CategoryPage_ThreadId,
        //            //            CategoryPage_ThreadTitle = _Forum.CategoryPage_ThreadTitle,
        //            //            ForumThread_Url = _Forum.Url,
        //            //            ForumThread_MessageCreated = _Forum.ThreadPage_MessageCreated,
        //            //            ForumThread_MessageId = _Forum.ThreadPage_MessageId,
        //            //            ForumThread_MessageText = _Forum.ThreadPage_MessageText,
        //            //            ForumThread_MessageUsername = _Forum.ThreadPage_MessageUsername,
        //            //            DateFormat = _Forum.DateFormat,
        //            //            TimeFormat = _Forum.TimeFormat,
        //            //            CrawlInterval = Convert.ToDateTime(_Forum.CrawlInterval),
        //            //            MessageCount = _Forum.MessageCount
        //            //        };
        //            //    });
        //            //    return "Forum Added in Database"; // Standard HTTP result, 201 CREATED
        //            //}
        //            //else
        //            //    return "Forum Already Exists";
        //            //});
        //    }
        //    catch (Exception ex)
        //    { }
        //}
    }
}
