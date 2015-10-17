using System;
using System.Text;
using System.Xml.Serialization;

namespace ACH.Domain
{
    [Serializable()]
    public partial class RichText
    {
        private string _html = string.Empty;

        [XmlText]
        [XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Nodes { get; set; }
        
        /// <summary>
        /// Override ToString method to return html property
        /// </summary>
        public override string ToString()
        {
            return Html;
        }

        /// <summary>
        /// Added extra Html property for better performance - So, dont have to populate field each time
        /// </summary>
        public string Html
        {
            get
            {
                if (string.IsNullOrEmpty(_html))
                {
                    var sb = new StringBuilder();
                    if (Nodes != null)
                    {
                        foreach (System.Xml.XmlNode item in Nodes)
                        {
                            sb.Append(item.OuterXml);
                        }
                    }

                    _html = sb.ToString();
                }

                return _html;
            }
        }
    }
}
