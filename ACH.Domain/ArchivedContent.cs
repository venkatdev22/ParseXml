using System;

namespace ACH.Domain
{
    public class ArchivedContent
    {
        public String Title { get; set; }
        public Link Url { get; set; }
        public string ImageSrc { get; set; }
        public string Summary { get; set; }
        public RichText Body { get; set; }
        public string Type { get; set; }

        public ArchivedContent()
        {
            
        }
    }
}
