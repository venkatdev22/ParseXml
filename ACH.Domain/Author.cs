//using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class Author
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public RichText BioDetails { get; set; }
        public string ProfilePicture { get; set; }
        public string TwitterID { get; set; }
        

        //[XmlIgnore]
        //public Link ArticleDetailLink { get; set; }
        //[XmlIgnore]
        //public IList<Article> Articles { get; set; }

        [XmlIgnore]
        public long ContentID { get; set; }
        
        //public Columnist()
        //{
        //    Articles = new List<Article>();
        //}
    }
}
