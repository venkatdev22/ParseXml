using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class ColumnistCarousel
    {
        [XmlElement("Name")]
        public string Header { get; set; }

        [XmlIgnore]
        public IList<Columnist> Columnists { get; set; }

        [XmlElement("Columnist")]
        public List<ColumnistGroup> ColumnistIds { get; set; }
        public ColumnistCarousel()
        {
            Columnists = new List<Columnist>();
        }
        public class ColumnistGroup
        {
            [XmlElement("Columnist")]
            public long ColumnistId { get; set; }
        }
    }
}
