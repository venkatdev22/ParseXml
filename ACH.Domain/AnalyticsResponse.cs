using System;
using System.Collections.Generic;

namespace ACH.Domain
{
    public class AnalyticsResponse
    {
        ///<summary>
        ///Column headers that list dimension names followed by the metric names. The
        ///order of dimensions and metrics is same as specified in the request.
        ///</summary>
        public IList<ColumnHeaderData> ColumnHeaders { get; set; }

        ///<summary>
        ///Analytics data rows, where each row contains a list of dimension values followed
        ///by the metric values. The order of dimensions and metrics is same as specified
        ///in the request.
        ///</summary>
        public IList<IList<string>> Rows { get; set; }

        ///<summary>
        ///Total values for the requested metrics over all the results, not just the
        ///results returned in this response. The order of the metric totals is same
        ///as the metric order specified in the request.
        ///</summary>
        public IDictionary<string, string> TotalsForAllResults { get; set; }

        public AnalyticsResponse()
        {
            ColumnHeaders = new List<ColumnHeaderData>();
        }
    }

    /// <summary>
    /// Supportive class for AnalyticsResponse.cs
    /// </summary>
    public class ColumnHeaderData
    {
        /// <summary>
        ///Column Type. Either DIMENSION or METRIC. 
        /// </summary>
        public string ColumnType { get; set; }

        /// <summary>
        ///Data type. Dimension column headers have only STRING as the data type. Metric
        ///column headers have data types for metric values such as INTEGER, DOUBLE,
        ///CURRENCY etc.
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        ///Column name.
        /// </summary>
        public string Name { get; set; }

        public ColumnHeaderData() { }
    }

}
