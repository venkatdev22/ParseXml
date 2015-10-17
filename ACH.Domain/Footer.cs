using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class Footer
    {
        public string FooterLogo { get; set; }

        public RichText CopyrightText { get; set; }

        public ContactDetail ContactUs { get; set; }

        [XmlElement("FooterLinks")]
        public List<FooterLink> FooterLinks { get; set; }

        [XmlElement("ResourceLinks")]
        public List<ResourceLink> ResourceLinks { get; set; }

        [XmlIgnore]
        public long ContentID { get; set; }
        [XmlIgnore]
        public Image Logo { get; set; }
        [XmlIgnore]
        public string LeftColumnHeader { get; set; }
        [XmlIgnore]
        public IList<Link> LeftColumnLinks { get; set; }
        [XmlIgnore]
        public string RightColumnHeader { get; set; }
        
        [XmlIgnore]
        public IList<Link> FooterNavigation { get; set; }

        public Footer()
        {
            LeftColumnLinks = new List<Link>();
            FooterNavigation = new List<Link>();
            Logo = new Image();
            ContactUs = new ContactDetail();
        }
    }

    /// <summary>
    /// Support de serialize of node 'FooterLinks'
    /// </summary>
    public class FooterLink
    {
        public AnchorTag a { get; set; }
    }
    /// <summary>
    ///  Support de serialize of node 'ResourceLinks'
    /// </summary>
    public class ResourceLink
    {
        public Link Resource { get; set; }
    }
   

    /// <summary>
    /// Support de serialize of node 'Contact us'
    /// </summary>
    public class ContactDetail
    {
        public string HeaderText { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string TollFreeNumber { get; set; }
        public Link AllContacts { get; set; }
    }
}
