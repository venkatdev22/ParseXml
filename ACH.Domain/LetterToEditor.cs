using System;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class LetterToEditor
    {
        public string Headline { get; set; }
        public RichText Summary { get; set; }
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public RichText Body { get; set; }
        public DateTime PostDate { get; set; }
        public RichText ReferenceLink { get; set; }
        [XmlIgnore]
        public long CategoryID { get; set; }
        [XmlIgnore]
        public string CategoryPath { get; set; }
        [XmlIgnore]
        public string Url { get; set; }
        [XmlIgnore]
        public long ContentID { get; set; }
        [XmlIgnore]
        public string DefaultSummary { get; set; }
        [XmlIgnore]
        public bool IsSummaryEmpty { get; set; }
    }
}
