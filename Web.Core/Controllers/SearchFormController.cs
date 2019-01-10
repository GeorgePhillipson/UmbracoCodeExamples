using System;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Web.Model.SearchViewModel;
using Web.Model.TestData;

namespace Web.Core.Controllers
{
    public class SearchFormController : RenderMvcController
    {
        [HttpGet]
        public ActionResult SearchForm(RenderModel objModel, string q)
        {
            var queryResult = TestSearchData.DogList().Where(x => string.Equals(x.PetTypeId, q, StringComparison.CurrentCultureIgnoreCase));

            var model = new SearchPageRenderMvcControllerViewModel(objModel.Content)
            {
                DisplaySearchResult = queryResult
            };
            return CurrentTemplate(model);
        }

        [HttpPost]
        public ActionResult SearchForm(RenderModel objModel, string q, string dummyParam)
        {
            var queryResult = TestSearchData.DogList().Where(x => string.Equals(x.PetTypeId, q, StringComparison.CurrentCultureIgnoreCase));

            var model = new SearchPageRenderMvcControllerViewModel(objModel.Content)
            {
                DisplaySearchResult = queryResult
            };
            return CurrentTemplate(model);
        }
    }

    public class SearchFormNotRouteController : SurfaceController
    {
        [HttpGet]
        public ActionResult SearchForm(string q)
        {
            var queryResult = TestSearchData.DogList().Where(x=>string.Equals(x.PetTypeId, q, StringComparison.CurrentCultureIgnoreCase));

            var model = new SearchPageSurfaceControllerViewModel
            {
                DisplaySearchResult = queryResult
            };

            return PartialView("~/Views/Partials/pvSurfaceSearch.cshtml",model);
        }

        [HttpPost]
        public ActionResult SearchForm(string q, string dummyParam)
        {
            var queryResult = TestSearchData.DogList().Where(x => string.Equals(x.PetTypeId, q, StringComparison.CurrentCultureIgnoreCase));

            var model = new SearchPageSurfaceControllerViewModel
            {
                DisplaySearchResult = queryResult
            };
            return PartialView("~/Views/Partials/pvSurfaceSearch.cshtml", model);
        }

        [HttpPost]
        public ActionResult SearchFormUmbraco(string q)
        {
            var queryResult = TestSearchData.DogList().Where(x => string.Equals(x.PetTypeId, q, StringComparison.CurrentCultureIgnoreCase));

            var model = new SearchPageSurfaceControllerViewModel
            {
                DisplaySearchResult = queryResult
            };
            return PartialView("~/Views/Partials/pvSurfaceSearch.cshtml", model);
        }

        [HttpGet]
        public ActionResult SearchFormUmbraco(string q, string dummyParam)
        {
            var queryResult = TestSearchData.DogList().Where(x => string.Equals(x.PetTypeId, q, StringComparison.CurrentCultureIgnoreCase));

            var model = new SearchPageSurfaceControllerViewModel
            {
                DisplaySearchResult = queryResult
            };
            return PartialView("~/Views/Partials/pvSurfaceSearch.cshtml", model);
        }
    }
}
