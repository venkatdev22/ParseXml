using System.Xml.Serialization;
namespace ACH.Domain
{
    public class PhotoGalleryItem
    {
        public string Photo { get; set; }
        public string Caption { get; set; }

        //[XmlIgnore]
        //public long Id { get; set; }
        
        [XmlIgnore]
        public string Url { get; set; }
    }
}
