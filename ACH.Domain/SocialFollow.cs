using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "SocialFollowIcons", IsNullable = false)]
    public class SocialFollow 
    {
        [XmlElement("SocialIcon")]
        public List<SocialIconItem> SocialIconList { get; set; }
    }

    public class SocialIconItem
    {

        [XmlElement("LinkField")]
        public SocialIconLink Link { get; set; }
        public string Icon { get; set; }
    }

    public class SocialIconLink
    {
        [XmlElement("a")]
        public AnchorTag Anchor { get; set; }
    }

}
