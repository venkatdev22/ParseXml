using System;
using System.Xml.Serialization;

namespace ACH.Domain
{
    [Serializable]
    public enum ACHContentType
    {
        [XmlEnum]
        Article = 0,
        [XmlEnum]
        Blog = 1,
        [XmlEnum]
        Letter = 2,
    }
}
