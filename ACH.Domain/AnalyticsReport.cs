using System;
namespace ACH.Domain
{
    public class AnalyticsReport
    {
        /// <summary>
        /// Url 
        /// </summary>
        public string PagePath { get; set; }

        /// <summary>
        /// Title of url
        /// </summary>
        public string PageTitle { get; set; }

        /// <summary>
        /// Content id-custom dimensions of url
        /// </summary>
        public long ContentId { get; set; }

        /// <summary>
        /// Content group-custom group of url
        /// </summary>
        public string ContentGroup { get; set; }

        /// <summary>
        /// Page view or hit count of url
        /// </summary>
        public int PageView { get; set; }

        /// <summary>
        /// Unique page view of url
        /// </summary>
        public int UniquePageView { get; set; }
    }
}
