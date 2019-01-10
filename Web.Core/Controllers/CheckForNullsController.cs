using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Web.Helper;
using Web.Model.NullCheck;

namespace Web.Core.Controllers
{
    public class CheckForNullsController : SurfaceController
    {
        public ActionResult Index()
        {
            var currentPage                 = CurrentPage.DocumentTypeAlias;
            var umbContent                  = UmbracoAssignedContentHelper.PageContentByAlias(currentPage);
            string displayImage             = string.Empty;
            string doesImageMediaHaveValue  = umbContent.GetPropertyValue<string>("testMediaImage", "NA");

            if (int.TryParse(doesImageMediaHaveValue, out _))
            {
                displayImage = umbContent.GetPropertyValue<IPublishedContent>("testMediaImage").Url;
            }

            var model = new CheckForNullViewModel
            {
                TestString  = umbContent.GetPropertyValue<string>("testString","I have no value"),
                TestRte     = umbContent.GetPropertyValue("testRte", new HtmlString("RTE has no value")),
                TestImage   = displayImage
            };

            return PartialView("~/Views/Partials/pvCheckForNulls.cshtml",model);
        }
    }
}
