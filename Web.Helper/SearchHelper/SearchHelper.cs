using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Web.Helper.SearchHelper
{
    public static class SearchHelper
    {
        public static string SearchPageUrl()
        {
            var umbContent          = UmbracoAssignedContentHelper.PageContentForIEnumerableIPublishedContent("homePage");
            string searchPageUrl    = umbContent.First().GetPropertyValue<IPublishedContent>("searchPage").Url;

            return searchPageUrl;
        }

        public static string SearchPageSurfaceUrl()
        {
            var umbContent = UmbracoAssignedContentHelper.PageContentForIEnumerableIPublishedContent("homePage");
            string searchPageUrl = umbContent.First().GetPropertyValue<IPublishedContent>("searchSurface").Url;

            return searchPageUrl;
        }
    }
}
