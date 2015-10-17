using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
namespace ACH.Domain
{
    public class Article
    {
        public string Headline { get; set; }
        public string Source { get; set; }
        public RichText LeadInCopy { get; set; }
        public string PullQuote { get; set; }
        public RichText Body { get; set; }
        public string SquareImage { get; set; }

        public PhotoGallery PhotoGallery { get; set; }

        /// <summary>
        /// By default, gets first photoItem image in photoGallery
        /// </summary>
        [XmlIgnore]
        public string RectangularImage
        {
            get
            {
                if (PhotoGallery != null)
                    return (PhotoGallery.PhotoGalleryItems != null
                        && PhotoGallery.PhotoGalleryItems.Count() > 0) ? PhotoGallery.PhotoGalleryItems.FirstOrDefault().Photo : string.Empty;

                return string.Empty;
            }
        }


        [XmlElement("Author")]
        public string strAuthorId { get; set; }

        [XmlIgnore]
        public long AuthorId 
        {
            get
            {
                long value;

                return !string.IsNullOrWhiteSpace(strAuthorId) && long.TryParse(strAuthorId, out value) ? (long)value : 0;
            }
         }
        
        [XmlIgnore]
        public Author Author { get; set; }
       
        public string AuthorName { get; set; }

        [XmlElement("DisplayColumnistsBio")]
        public string strDisplayColumnistsBio { get; set; }
        
        [XmlIgnore]
        public bool DisplayColumnistsBio
        {
            get
            {
                return !string.IsNullOrEmpty(strDisplayColumnistsBio) ? strDisplayColumnistsBio == "1" : false;
            }
        }

        [XmlElement("PostDate")]
        public string strPostDate { get; set; }
        
        [XmlIgnore]
        public DateTime PostDate
        {
            get
            {
                return (!string.IsNullOrEmpty(strPostDate)) ? DateTime.Parse(strPostDate) : DateTime.Today;
            }
            set
            {
                strPostDate = value.ToShortDateString();
            }
        }


        [XmlIgnore]
        public string Url { get; set; }

        [XmlIgnore]
        public string CategoryPath { get; set; }
        
        [XmlIgnore]
        public long CategoryID { get; set; }

        [XmlIgnore]
        public long ContentID { get; set; }

        //public Image RectangularImage
        //{
        //    get
        //    {
        //        return new Image() 
        //        {
        //            ImageSrc=strRectangularImage,
        //            ImageAlt=System.IO.Path.GetFileNameWithoutExtension(strRectangularImage)
        //        };
        //    }
        //}
        //public Image SquareImage
        //{
        //    get
        //    {
        //        return new Image()
        //        {
        //            ImageSrc = strSquareImage,
        //            ImageAlt = System.IO.Path.GetFileNameWithoutExtension(strSquareImage)
        //        };
        //    }
        //}




        //[XmlIgnore]
        //public string RelatedArticleIds { get; set; }


        //[XmlIgnore]
        //public string Tags { get; set; }



        //[XmlIgnore]
        //public string CopyrightText { get; set; }

        //[XmlIgnore]
        //public string strPhotoGalleryImages { get; set; }

        public Article()
        {
            PhotoGallery = new PhotoGallery();   
        }
    }
}
