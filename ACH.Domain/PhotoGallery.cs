using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class PhotoGallery
    {
        public string Title { get; set; }
        public string Credit { get; set; }

        [XmlElement("PhotoItems")]
        public List<PhotoGalleryItem> PhotoGalleryItems { get; set; }


        [XmlIgnore]
        public DateTime DateCreated { get; set; }

        [XmlIgnore]
        public string Url { get; set; }
        
        [XmlIgnore]
        public long ContentID { get; set; }

        //[XmlIgnore]
        //public List<PhotoGalleryGroup> PhotoItemIds { get; set; }
        //public string EmailID { get; set; }

        public PhotoGallery()
        {
            PhotoGalleryItems = new List<PhotoGalleryItem>();

            //PhotoItemIds = new List<PhotoGalleryGroup>();
        }
    }

    //public class PhotoGalleryGroup
    //{
    //    public long PhotoItemIds { get; set; }
    //}
}
