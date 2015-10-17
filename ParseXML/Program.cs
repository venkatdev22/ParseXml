using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml.Linq;
using ACH;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using ACH.Common;
using ACH.Domain;
namespace ParseXML
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Xdoc = XElement.Load(@"c:\users\user\documents\visual studio 2012\Projects\PareseXml\ParseXML\SmartForms\CategoryArticleListing.xml");
                PocoBinder poco = new PocoBinder();
                var obj = poco.Transform<ACH.Domain.CategoryArticleListing>(Xdoc.ToString());
                Console.WriteLine(obj.FeaturedArticles.FeaturedTaxonomy);

                Console.ReadKey();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex);
                Console.ReadKey();
            }
        }
    }
}

namespace ACH.Common
{
    public class PocoBinder
    {
        public TPoco Transform<TPoco>(string xml) where TPoco : class
        {
            if (xml == null) throw new ArgumentNullException("xml", "argument can not be null");

            var document = new XmlDocument();

            try
            {
                document.LoadXml(xml);
            }
            catch (XmlException x)
            {
                throw new Exception("Invalid html content", x);
            }

            if (document.FirstChild != null)
            {
                var innerXml = document.FirstChild.InnerXml;

               // var innerXml = document.InnerXml;

                var serializer = new XmlSerializer(typeof(TPoco));

                try
                {
                    using (XmlReader reader = XmlReader.Create(new StringReader(innerXml)))
                    {
                        return serializer.Deserialize(reader) as TPoco;
                    }
                }
                catch (InvalidOperationException e)
                {
                    throw new Exception("Invalid structured content", e);
                }
            }

            return null;
        }
    }
}

namespace test
{
    public class Article
    {
        public string Headline { get; set; }
        public string ByLine { get; set; }
        public RichText Summary { get; set; }
        public string PullQuote { get; set; }
        public RichText Body { get; set; }

        [XmlElement("PhotoGallery")]
        public PhotoGallery PhotoGallery { get; set; }
        
        [XmlElement("SquareImage")]
        public string strSquareImage { get; set; }

        /// <summary>
        /// Author content Id
        /// </summary>
        public long Columnist { get; set; }

        public string AuthorName { get; set; }

        public string strDisplayColumnistsBio { get; set; }

        [XmlElement("PostDate")]
        public string strReleaseDate { get; set; }
        public DateTime ReleaseDate
        {
            get
            {
                return (!string.IsNullOrEmpty(strReleaseDate)) ? DateTime.Parse(strReleaseDate) : DateTime.Today;
            }
            set
            {
                strReleaseDate = value.ToShortDateString();
            }
        }
    }



}