using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Web.Core.Controllers
{
    public class HomePageController : RenderMvcController
    {
        public ActionResult HomePage(RenderModel objModel)
        {
            return CurrentTemplate(objModel);
        }
    }
}
