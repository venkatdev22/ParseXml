using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACH.Domain
{
    public class CategoryEventListing
    {
        public string Header { get; set; }
        public Link HeaderLink { get; set; }
        public IList<Article> Articles { get; set; }
        public string TaxonomyPath { get; set; }
        public long TaxonomyID { get; set; }
    }
}
