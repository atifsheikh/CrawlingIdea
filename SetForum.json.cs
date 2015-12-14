using OneKey.Database.Config;
using Starcounter;
using System;

namespace OneKey
{
    partial class SetForum : Json
    {
        void SetForum()
        {
            try
            {
                Handle.POST("/SetForum",(Forum _Forum) =>
                {

                    //if _Forum.Name exist do not add the forum
                    Db.Transaction(() =>
                    {
                        var forum = new Forum()
                        {
                            Url = _Forum.Url,
                            Updated = DateTime.Now,
                            StringExternalId = "",
                            LatestCrawlTime = DateTime.Now,
                            ExternalId = 0,
                            Created = DateTime.Now,
                            Name = _Forum.Name,
                            ForumType = _Forum.ForumType,
                            Description = _Forum.Description,
                            Region = _Forum.Region,
                            Language = _Forum.Language,
                            Culture = _Forum.Culture,
                            LoginUrl = _Forum.LoginUrl,
                            PostThreadUrl = _Forum.PostThreadUrl,
                            PostReplyUrl = _Forum.PostReplyUrl,
                            StartCrawlPage = _Forum.StartCrawlPage,
                            CrawlCategoryPageInterval = _Forum.CrawlCategoryPageInterval,
                            CrawlThreadPageInterval = _Forum.CrawlThreadPageInterval,
                            IsCategoryStringExternalId = _Forum.IsCategoryStringExternalId,
                            IsThreadStringExternalId = _Forum.IsThreadStringExternalId,
                            FixedCookies = _Forum.FixedCookies,
                            Cookie1 = _Forum.Cookie1,
                            Cookie2 = _Forum.Cookie2,
                            Cookie3 = _Forum.Cookie3,
                            Cookie4 = _Forum.Cookie4,
                            PostAttribute1 = _Forum.PostAttribute1,
                            PostAttribute2 = _Forum.PostAttribute2,
                            LoginAttributes = _Forum.LoginAttributes,
                            PostThreadAttributes = _Forum.PostThreadAttributes,
                            PostReplyAttributes = _Forum.PostReplyAttributes,
                            PostQuoteAttributes = _Forum.PostQuoteAttributes,
                            StorePostRegex = _Forum.StorePostRegex,
                            StoreThreadRegex = _Forum.StoreThreadRegex,
                            Origin = _Forum.Origin,
                            Encoding = _Forum.Encoding,
                            UrlPage_Id = _Forum.UrlPage_Id,
                            UrlPage_Title = _Forum.UrlPage_Title,
                            CategoryPage_Url = _Forum.CategoryPage_Url,
                            CategoryPage_ThreadId = _Forum.CategoryPage_ThreadId,
                            CategoryPage_ThreadTitle = _Forum.CategoryPage_ThreadTitle,
                            ForumThread_Url = _Forum.Url,
                            ForumThread_MessageCreated = _Forum.ForumThread_MessageCreated,
                            ForumThread_MessageId = _Forum.ForumThread_MessageId,
                            ForumThread_MessageText = _Forum.ForumThread_MessageText,
                            ForumThread_MessageUsername = _Forum.ForumThread_MessageUsername,
                            DateFormat = _Forum.DateFormat,
                            TimeFormat = _Forum.TimeFormat,
                            CrawlInterval = Convert.ToDateTime(_Forum.CrawlInterval),
                            MessageCount = _Forum.MessageCount
                        };
                    });
                    return 201; // Standard HTTP result, 201 CREATED
                });
            }
            catch (Exception ex)
            { }
        }
    }
}
