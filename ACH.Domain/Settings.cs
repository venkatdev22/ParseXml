using System.Xml.Serialization;
using System.Collections.Generic;
namespace ACH.Domain
{
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "Settings", IsNullable = false)]
    public class GlobalSettings
    {
        [XmlIgnore]
        public long ContentId { get; set; }

        public string Logo { get; set; }

        [XmlElement("FooterSmartFormContentID")]
        public string strFooterSmartFormContentID { get; set; }

        [XmlIgnore]
        public long FooterSmartFormContentID
        {
            get
            {
                long value;
                return !string.IsNullOrWhiteSpace(strFooterSmartFormContentID) && long.TryParse(strFooterSmartFormContentID, out value) ? (long)value : 0;
            }
        }

        [XmlElement("UtilityNavigationMenuID")]
        public string srtUtilityNavigationMenuID { get; set; }

        [XmlIgnore]
        public long UtilityNavigationMenuID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(srtUtilityNavigationMenuID) && long.TryParse(srtUtilityNavigationMenuID, out value) ? (long)value : 0;
            }
        }

        [XmlElement("MainNavigationID")]
        public string strMainNavigationID { get; set; }

        [XmlIgnore]
        public long MainNavigationID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strMainNavigationID) && long.TryParse(strMainNavigationID, out value) ? (long)value : 0;
            }
        }

        public string AppendToPageTitle { get; set; }

        public string FacebookProfileURL { get; set; }

        public string PinterestProfileURL { get; set; }

        public string TwitterProfileURL { get; set; }

        [XmlElement("RSSFeed")]
        public List<string> RSSFeed { get; set; }

        public string CNSYoutubeChannel { get; set; }
        public string ACHYoutubeChannel { get; set; }

        [XmlElement("TaxonomyCustomPropertyID")]
        public string strTaxonomyCustomPropertyID { get; set; }

        [XmlElement("BlogSmartFormID")]
        public string strBlogSmartFormID { get; set; }

        [XmlElement("DisqusConfiguration")]
        public string DisqusConfiguration { get; set; }

        [XmlElement("FacebookConfiguration")]
        public string FacebookConfiguration { get; set; }

        [XmlElement("FeaturedTaxonomyID")]
        public string strFeaturedTaxonomyID { get; set; }

        [XmlElement("TagMetaID")]
        public string strTagsMetaID { get; set; }

        [XmlElement("EventSmartFormID")]
        public string strEventSmartFormID { get; set; }

        [XmlElement("EventDefaultHeroImage")]
        public string EventDefaultHeroImage { get; set; }

        [XmlElement("FeaturedEventsTaxID")]
        public string strFeaturedEventTaxonomyID { get; set; }

        [XmlElement("FeaturedArticleTaxID")]
        public string strFeaturedArticleTaxonomyID { get; set; }

        [XmlElement("FeaturedBlogTaxID")]
        public string strFeaturedBlogTaxonomyID { get; set; }

        [XmlElement("FeaturedClassifiedsTaxID")]
        public string strFeaturedClassifiedsTaxonomyID { get; set; }

        [XmlElement("FeaturedLettersTaxID")]
        public string strFeaturedLetterTaxonomyID { get; set; }

        [XmlElement("FeaturedVideoTaxonomyID")]
        public string strFeaturedVideoTaxonomyID { get; set; }

        [XmlElement("FeaturedPhotoGalleryTaxonomyID")]
        public string strFeaturedPhotoGalleryTaxonomyID { get; set; }

        public string FacebookAppIdEN { get; set; }

        public string FacebookAdminsId { get; set; }

        [XmlElement("CategoryArticleListingSmartfromID")]
        public string strCategoryArticleListingXmlConfigId { get; set; }

        [XmlElement("ArticlesSmartformConfigID")]
        public string strArticlesSmartformConfigID { get; set; }

        [XmlElement("VideoSmartformID")]
        public string strVideoSmartformID { get; set; }

        [XmlElement("ColumnistDefaultProfilePicture")]
        public string ColumnistDefaultProfilePicture { get; set; }

        [XmlElement("ColumnistSmartformConfigID")]
        public string strColumnistSmartformConfigID { get; set; }

        [XmlElement("ClassifiedSmartformID")]
        public string strClassifieldsSmartformID { get; set; }


        [XmlElement("RelatedArticleMetaID")]
        public string RelatedArticleMetaID { get; set; }

        [XmlElement("LetterToEditorSmartformID")]
        public string strLetterToEditorSmartformID { get; set; }


        [XmlElement("ClassifiedTaxonomyID")]
        public string strClassifiedTaxonomyID { get; set; }

        [XmlElement("ClassifiedFolderID")]
        public string strClassifiedFolderID { get; set; }

        [XmlElement("ClassifiedPostBackContentID")]
        public string strClassifiedPostBackContentID { get; set; }

        [XmlElement("LetterToEditorFolderID")]
        public string strLetterToEditorFolderID { get; set; }

        [XmlElement("LetterToEditorPostBackContentID")]
        public string strLetterToEditorPostBackContentID { get; set; }

        [XmlElement("BlogFolderID")]
        public string strBlogFolderID { get; set; }

        [XmlElement("EventFolderID")]
        public string strEventFolderID { get; set; }

        [XmlElement("EventPostBackContentID")]
        public string strEventPostBackContentID { get; set; }

        [XmlIgnore]
        public long ColumnistSmartformConfigID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strColumnistSmartformConfigID) && long.TryParse(strColumnistSmartformConfigID, out value) ? (long)value : 0;
            }
        }

        public long BlogSmartFormID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strBlogSmartFormID) && long.TryParse(strBlogSmartFormID, out value) ? (long)value : 0;
            }
        }
        public long ClassifieldsSmartformID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strClassifieldsSmartformID) && long.TryParse(strClassifieldsSmartformID, out value) ? (long)value : 0;
            }
        }
        public long VideoSmartformID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strVideoSmartformID) && long.TryParse(strVideoSmartformID, out value) ? (long)value : 0;
            }
        }
        public long FeaturedTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedTaxonomyID) && long.TryParse(strFeaturedTaxonomyID, out value) ? (long)value : 0;
            }
        }

        public long TagsMetaID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strTagsMetaID) && long.TryParse(strTagsMetaID, out value) ? (long)value : 0;
            }
        }

        public long LetterToEditorSmartformID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strLetterToEditorSmartformID) && long.TryParse(strLetterToEditorSmartformID, out value) ? (long)value : 0;
            }
        }
        public long EventSmartFormID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strEventSmartFormID) && long.TryParse(strEventSmartFormID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long FeaturedEventTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedEventTaxonomyID) && long.TryParse(strFeaturedEventTaxonomyID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long FeaturedArticleTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedArticleTaxonomyID) && long.TryParse(strFeaturedArticleTaxonomyID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long FeaturedBlogTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedBlogTaxonomyID) && long.TryParse(strFeaturedBlogTaxonomyID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long FeaturedClassifiedsTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedClassifiedsTaxonomyID) && long.TryParse(strFeaturedClassifiedsTaxonomyID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long FeaturedLetterTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strFeaturedLetterTaxonomyID) && long.TryParse(strFeaturedLetterTaxonomyID, out value) ? (long)value : 0;
            }
        }
        public long FeaturedVideoTaxonomyID
        {
            get
            {
                long value;
                return !string.IsNullOrWhiteSpace(strFeaturedVideoTaxonomyID) && long.TryParse(strFeaturedVideoTaxonomyID, out value) ? (long)value : 0;
            }
        }

        public long FeaturedPhotoGalleryTaxonomyID
        {
            get
            {
                long value;
                return !string.IsNullOrWhiteSpace(strFeaturedPhotoGalleryTaxonomyID) && long.TryParse(strFeaturedPhotoGalleryTaxonomyID, out value) ? (long)value : 0;
            }
        }
        public long CategoryArticleListingXmlConfigId
        {
            get
            {
                long value;
                return !string.IsNullOrWhiteSpace(strCategoryArticleListingXmlConfigId) && long.TryParse(strCategoryArticleListingXmlConfigId, out value) ? (long)value : 0;
            }
        }

        public long ArticlesSmartformConfigID
        {
            get
            {
                long value;
                return !string.IsNullOrWhiteSpace(strArticlesSmartformConfigID) && long.TryParse(strArticlesSmartformConfigID, out value) ? (long)value : 0;
            }
        }

        public long ClassifiedTaxonomyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strClassifiedTaxonomyID) && long.TryParse(strClassifiedTaxonomyID, out value) ? (long)value : 0;
            }
        }
        public long ClassifiedFolderID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strClassifiedFolderID) && long.TryParse(strClassifiedFolderID, out value) ? (long)value : 0;
            }
        }
        public long ClassifiedPostBackContentID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strClassifiedPostBackContentID) && long.TryParse(strClassifiedPostBackContentID, out value) ? (long)value : 0;
            }
        }
        public long LetterToEditorFolderID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strLetterToEditorFolderID) && long.TryParse(strLetterToEditorFolderID, out value) ? (long)value : 0;
            }
        }
        public long BlogFolderID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strBlogFolderID) && long.TryParse(strBlogFolderID, out value) ? (long)value : 0;
            }
        }
        public long LetterToEditorPostBackContentID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strLetterToEditorPostBackContentID) && long.TryParse(strLetterToEditorPostBackContentID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long TaxonomyCustomPropertyID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strTaxonomyCustomPropertyID) && long.TryParse(strTaxonomyCustomPropertyID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long EventFolderID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strEventFolderID) && long.TryParse(strEventFolderID, out value) ? (long)value : 0;
            }
        }

        [XmlIgnore]
        public long EventPostBackContentID
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strEventPostBackContentID) && long.TryParse(strEventPostBackContentID, out value) ? (long)value : 0;
            }
        }
    }
}
