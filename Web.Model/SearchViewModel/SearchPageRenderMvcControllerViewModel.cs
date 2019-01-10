using System.Collections.Generic;
using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Web.Model.TestData;

namespace Web.Model.SearchViewModel
{
    public class SearchPageRenderMvcControllerViewModel : RenderModel
    {
        public SearchPageRenderMvcControllerViewModel(IPublishedContent content, CultureInfo culture) : base(content, culture)
        {
        }

        public SearchPageRenderMvcControllerViewModel(IPublishedContent content) : base(content)
        {
        }
        public IEnumerable<TypeOfPets> DisplaySearchResult { get; set; }
    }

    public class SearchPageSurfaceControllerViewModel
    {
        public IEnumerable<TypeOfPets> DisplaySearchResult { get; set; }
    }
}
