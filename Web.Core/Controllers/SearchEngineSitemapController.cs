using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Xml.Serialization;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Web.Model.XmlSitemap;

namespace Web.Core.Controllers
{
    public class SearchEngineSitemapController : RenderMvcController
    {
        public override ActionResult Index(RenderModel model)
        {
            var sitemap = GetSitemap();
            return Content(SitemapToXml(sitemap), "text/xml");
        }

        private Sitemap GetSitemap()
        {
            var sitemap = new Sitemap
            {
                SiteMapItems = new List<XmlSitemapModel>()

            };
            var rootItem = Umbraco.TypedContentAtRoot().FirstOrDefault();
            AddItemToList(sitemap.SiteMapItems, rootItem);

            return sitemap;
        }
        private static void AddItemToList(ICollection<XmlSitemapModel> urlList, IPublishedContent item)
        {
            if (item.GetPropertyValue<bool>("displayInXMLSitemap") && item.TemplateId != 0)
            {
                if (!string.IsNullOrEmpty(item.GetPropertyValue<string>("changeFrequency")))
                {
                    urlList.Add(new XmlSitemapModel
                    {
                        Url             = item.UrlWithDomain(),
                        LastModified    = item.UpdateDate.ToString("yyyy-MM-dd"),
                        ChangeFreq      = item.GetPropertyValue<string>("changeFrequency")
                    });
                }
                else
                {
                    urlList.Add(new XmlSitemapModel
                    {
                        Url             = item.UrlWithDomain(),
                        LastModified    = item.UpdateDate.ToString("yyyy-MM-dd")
                    });
                }
                
            }

            foreach (var childItem in item.Children())
            {
                AddItemToList(urlList, childItem);
            }
        }

        private static string SitemapToXml(Sitemap sitemap)
        {
            string xml;
            var xmlSerialiser = new XmlSerializer(sitemap.GetType());

            using (var stringWriter = new Utf8StringWriter())
            {
                xmlSerialiser.Serialize(stringWriter, sitemap);
                xml = stringWriter.ToString();
            }

            return xml;
        }

        private class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }
    }
}
