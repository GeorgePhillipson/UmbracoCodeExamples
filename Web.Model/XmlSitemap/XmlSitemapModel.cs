using System.Collections.Generic;
using System.Xml.Serialization;

namespace Web.Model.XmlSitemap
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class Sitemap
    {
        [XmlElement("url", Type = typeof(XmlSitemapModel))]
        public List<XmlSitemapModel> SiteMapItems { get; set; }
    }

    public class XmlSitemapModel
    {
        [XmlElement("loc")]
        public string Url           { get; set; }

        [XmlElement("lastmod")]
        public string LastModified  { get; set; }

        [XmlElement("changefreq")]
        public string ChangeFreq    { get; set; }

        [XmlElement("priority")]
        public string Priority      { get; set; }
    }
}
