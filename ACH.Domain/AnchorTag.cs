using System.Xml.Serialization;
namespace ACH.Domain
{
    [XmlTypeAttribute()]
    public class AnchorTag
    {
        [XmlAttributeAttribute()]
        public string title { get; set; }

        [XmlAttributeAttribute()]
        public string href { get; set; }

        [XmlAttributeAttribute()]
        public string target { get; set; }

        [XmlTextAttribute()]
        public string Value { get; set; }
    }
}
