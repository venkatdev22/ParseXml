using System;
using System.Xml.Serialization;

namespace ACH.Domain
{

    public class Blog
    {
        public string Headline { get; set; }
        public string ByLine { get; set; }
        public RichText LeadInCopy { get; set; }
        public RichText Summary { get; set; }
        public RichText Body { get; set; }
        public DateTime PostDate { get; set; }
        public string Quote { get; set; }
        public string RectangularImage { get; set; }
        public string SquareImage { get; set; }
        public string CopyrightText { get; set; }
        public long PhotoGalleryImages { get; set; }
        public long Columnist { get; set; }

        [XmlIgnore]
        public string Url { get; set; }
        [XmlIgnore]
        public PhotoGallery PhotoGalleryDetails { get; set; }
        [XmlIgnore]
        public Columnist ColumnistDetail { get; set; }
        [XmlIgnore]
        public string CategoryPath { get; set; }
        [XmlIgnore]
        public long CategoryID { get; set; }
        [XmlIgnore]
        public long ContentID { get; set; }
        [XmlIgnore]
        public string DefaultSummary { get; set; }

        [XmlIgnore]
        public bool IsSummaryEmpty { get; set; }
    }

}
