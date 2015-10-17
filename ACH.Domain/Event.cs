using System;
using System.Xml.Serialization;

namespace ACH.Domain
{
    public class Event
    {
        public string Title { get; set; }

        [XmlElement("StartDate")]
        public string strStartDate { get; set; }

        [XmlElement("StartTime")]
        public string strStartTime { get; set; }

        [XmlElement("EndDate")]
        public string strEndDate { get; set; }

        [XmlElement("EndTime")]
        public string strEndTime { get; set; }
        
        [XmlIgnore]
        public DateTime StartDate 
        {
            get
            {
                return Convert.ToDateTime(strStartDate);
            }
            set
            {
                strStartDate = value.ToShortDateString();
            }
        }

        [XmlIgnore]
        public DateTime StartTime 
        {
            get
            {
                return Convert.ToDateTime(strStartDate + " " + strStartTime);
            }
            set
            {
                strStartTime = value.ToShortTimeString();
            }
        }

        [XmlIgnore]
        public DateTime EndDate
        {
            get
            {
                return Convert.ToDateTime((strEndDate != "")? strEndDate : DateTime.MinValue.ToShortDateString());
            }
            set
            {
                strEndDate = value.ToShortDateString();
            }
        }

        [XmlIgnore]
        public DateTime EndTime
        {
            get
            {
                return Convert.ToDateTime(strEndDate + " " + strEndTime);
            }
            set
            {
                strEndTime = value.ToShortTimeString();
            }
        }

        public RichText ContactInfo { get; set; }
        public string SponsoredBy { get; set; }
        public RichText EventDescription { get; set; }

        [XmlElement("EventImage")]
        public string EventImage { get; set; }        

        [XmlElement("Venue")]
        public Venue Venue { get; set; }

        [XmlIgnore]
        public string EventQuickLink { get; set; }

        [XmlIgnore]
        public string Tags { get; set; }

        [XmlIgnore]
        public long ContentID { get; set; }
    }

    /// <summary>
    /// Venue class
    /// </summary>
    public class Venue
    {
        [XmlElement("Name")]
        public string VenueName { get; set; }

        [XmlElement("AddressOne")]
        public string AddressOne { get; set; }

        [XmlElement("AddressTwo")]
        public string AddressTwo { get; set; }

        [XmlElement("City")]
        public string City { get; set; }

        [XmlElement("State")]
        public string State { get; set; }

        [XmlElement("ZipCode")]
        public string ZipCode { get; set; }
    }
}
