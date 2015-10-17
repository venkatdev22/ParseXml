using System.Collections.Generic;

namespace ACH.Domain
{
    public class Archive
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public IList<Archive> ChildArchive { get; set; }
    }
}
