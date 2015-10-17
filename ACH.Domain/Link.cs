using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class Link
    {
        [XmlElement("a")]
        public AnchorTag Anchor { get; set; }

        public Link()
        {
            ChildLinks = new List<Link>();
        }

        [XmlIgnore]
        public string Text { get; set; }

        [XmlIgnore]
        public string Url { get; set; }

        [XmlIgnore]
        public string IconUrl { get; set; }

        [XmlIgnore]
        public string Target { get; set; }

        [XmlIgnore]
        public IList<Link> ChildLinks { get; set; }

        /// <summary>
        /// used to indicate active elements
        /// </summary>
        public bool IsActive { get; set; }
    }
}
