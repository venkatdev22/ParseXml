using System;
using System.Collections.Generic;

namespace ACH.Domain
{
    public class AnalyticsRequest
    {
        public string ids { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public List<string> metrics { get; set; }
        public List<string> Dimensions { get; set; }
        public string Sort { get; set; }
        public int MaxResults { get; set; }
        public string Filters{get;set;}

        public AnalyticsRequest()
        {
            metrics = new List<string>();
            Dimensions = new List<string>();
        }
    }
}
