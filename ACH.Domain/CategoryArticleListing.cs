using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class CategoryArticleListing
    {
        public string Header { get; set; }

        public Link Link { get; set; }

        public FeaturedArticlesCategory FeaturedArticles { get; set; }
        
        public ArticleTaxonomy ArticleTaxonomy { get; set; }

        [XmlIgnore]
        public long ContentID { get; set; }

        [XmlIgnore]
        public List<Article> Articles { get; set; }

        public CategoryArticleListing()
        {
            Articles = new List<Article>();
        }
    }

    public class FeaturedArticlesCategory
    {
        [XmlElement("FeaturedTaxonomy")]
        public string strFeaturedTaxonomy { get; set; }

        [XmlIgnore]
        public long FeaturedTaxonomy
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedTaxonomy) && long.TryParse(strFeaturedTaxonomy, out value) ? (long)value : 0;
            }
        }
    }

    public class ArticleTaxonomy
    {
        [XmlElement("Taxonomy")]
        public string strTaxonomyId { get; set; }

        [XmlIgnore]
        public long TaxonomyId
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strTaxonomyId) && long.TryParse(strTaxonomyId, out value) ? (long)value : 0;
            }
        }
    }
}
