using System.Linq;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Web.Helper;
using Web.Model.ResponsiveImages;

namespace Web.Core.Controllers
{
    public class ResponsiveImageController : SurfaceController
    {
        public ActionResult Index()
        {
            var currentPage = CurrentPage.DocumentTypeAlias;
            var umbContent = UmbracoAssignedContentHelper.PageContentByAlias(currentPage);

            var xLargeImage         = umbContent.GetCropUrl(propertyAlias: "responsiveImageExample", cropAlias: "X-Large-Desktop");
            var desktop             = umbContent.GetCropUrl(propertyAlias: "responsiveImageExample", cropAlias: "Desktop");
            var landScape           = umbContent.GetCropUrl(propertyAlias: "responsiveImageExample", cropAlias: "LandScape");
            var tablet              = umbContent.GetCropUrl(propertyAlias: "responsiveImageExample", cropAlias: "Tablet");
            var mobile              = umbContent.GetCropUrl(propertyAlias: "responsiveImageExample", cropAlias: "Mobile");

            var crops               = umbContent.GetPropertyValue<ImageCropDataSet>("responsiveImageExample");

            int cropWidthXLarge     = crops.Crops.First(x => x.Alias.InvariantEquals("X-Large-Desktop")).Width;
            int cropWidthDesktop    = crops.Crops.First(x => x.Alias.InvariantEquals("DeskTop")).Width;
            int cropWidthLandScape  = crops.Crops.First(x => x.Alias.InvariantEquals("LandScape")).Width;
            int cropWidthTablet     = crops.Crops.First(x => x.Alias.InvariantEquals("Tablet")).Width;
            int cropWidthMobile     = crops.Crops.First(x => x.Alias.InvariantEquals("Mobile")).Width;

            var model = new ResponsiveImageViewModel
            {
                XLargeImage         = xLargeImage,
                Desktop             = desktop,
                LandScape           = landScape,
                Tablet              = tablet,
                Mobile              = mobile,
                CropWidthXLarge     = $"{cropWidthXLarge}w",
                CropWidthDesktop    = $"{cropWidthDesktop}w",
                CropWidthLandscape  = $"{cropWidthLandScape}w",
                CropWidthTablet     = $"{cropWidthTablet}w",
                CropWidthMobile     = $"{cropWidthMobile}w"
            };

            return PartialView("~/Views/Partials/pvImageCropper.cshtml",model);
        }
    }
}
