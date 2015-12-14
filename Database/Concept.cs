using Starcounter;

namespace OneKey.Database
{
    [Database]
    public class Concept
    {
        public string Name;
        public string ObId { get { return DbHelper.GetObjectID(this); } }
    }
}
