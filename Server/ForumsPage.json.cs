using Starcounter;
using System.Collections;

namespace OneKey.Server
{
    [ForumsPage_json.Forums]
    partial class Forums : Json
    {
        public IEnumerable ForumList_
        {
            get
            {
                return Db.SQL<OneKey.Database.Config.Forum>("SELECT c FROM OneKey.Database.Config.Forum c");
            }
        }
    }




    [ForumsPage_json]

    partial class ForumsPage :  Json
    {
        public override string AsMimeType(MimeType type)
        {
            if (type == MimeType.Text_Html)
            {
                return X.GET<string>(Html);
            }
            return base.AsMimeType(type);
        }
    }
}
