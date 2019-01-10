using System.Text.RegularExpressions;
using System.Web.Mvc;
using Umbraco.Core.PropertyEditors.ValueConverters;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Web.Helper;
using Web.Helper.EnumHelper;
using Web.Model.ColourPicker;

namespace Web.Core.Controllers
{
    public class EnumExampleController : SurfaceController
    {
        public ActionResult Index()
        {
            var currentPage = CurrentPage.DocumentTypeAlias;
            var umbContent = UmbracoAssignedContentHelper.PageContentByAlias(currentPage);

            string textColour       = umbContent.GetPropertyValue<ColorPickerValueConverter.PickedColor>("textColour").Label;
            string backgroundColour = umbContent.GetPropertyValue<ColorPickerValueConverter.PickedColor>("sectionBackgroundColour").Label;
            int fontSize = umbContent.GetPropertyValue<int>("fontSize");

            string displayTextColour        = "black";
            string displayBackgroundColour  = "white";

            switch (textColour)
            {
                case nameof(EnumColourPicker.ColourPickerEnum.Red):
                    displayTextColour = "textRed";
                    break;
                case nameof(EnumColourPicker.ColourPickerEnum.Black):
                    displayTextColour = "textBlack";
                    break;
            }

            switch (Regex.Replace(backgroundColour," ",""))
            {
                case nameof(EnumColourPicker.ColourPickerEnum.Tomato):
                    displayBackgroundColour = "backgroundColourTomato";
                    break;
                case nameof(EnumColourPicker.ColourPickerEnum.DarkOrange):
                    displayBackgroundColour = "backgroundColourDarkOrange";
                    break;
            }

            string displayfontSize = DisplayFontSize.SectionFontSize(fontSize);

            var model = new ColourPickerViewModel
            {
                TextColour          = displayTextColour,
                BackgroundColour    = displayBackgroundColour,
                FontSize            = displayfontSize
            };

            return PartialView("~/Views/Partials/pvEnumColourExample.cshtml",model);
        }
    }
}
