using System;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class Classified
    {
        public string Title { get; set; }
        public RichText Summary { get; set; }
        public string Image { get; set; }
        public RichText Body { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PostDate { get; set; }
        public string EmailID { get; set; }
        public string AdID { get; set; }
        [XmlIgnore]
        public long ContentID { get; set; }
        [XmlIgnore]
        public string Url { get; set; }
        [XmlIgnore]
        public long CategoryID { get; set; }
        [XmlIgnore]
        public string CategoryName { get; set; }
        [XmlIgnore]
        public string CategoryPath { get; set; }
        [XmlIgnore]
        public string DefaultSummary { get; set; }
        [XmlIgnore]
        public bool IsSummaryEmpty { get; set; }
        [XmlIgnore]
        public string PageView { get; set; }
    }
}
