using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Web.Helper
{
    public static class UmbracoAssignedContentHelper
    {
        public static IEnumerable<IPublishedContent> PageContentForIEnumerableIPublishedContent(string pageName)     
        {
            UmbracoHelper umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            IEnumerable<IPublishedContent> data = umbracoHelper.TypedContentAtRoot().First().DescendantsOrSelf(pageName);
            return data;
        }

        public static IPublishedContent PageContentByAlias(string pageName)
        {
            UmbracoHelper umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            IPublishedContent currentPage = umbracoHelper.AssignedContentItem;
            IPublishedContent pageContent = currentPage.AncestorOrSelf(1).DescendantOrSelf(pageName);
            return pageContent;
        }
    }
}
