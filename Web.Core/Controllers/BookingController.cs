using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Web.Helper;

namespace Web.Core.Controllers
{
    public class BookingController : SurfaceController
    {
        public JsonResult GetCurrentBookings()
        {
            List<IPublishedContent> bookingDetails = UmbracoAssignedContentHelper.PageContentForIEnumerableIPublishedContent("bookings").DescendantsOrSelf("year").Where(x => x.GetPropertyValue<bool>("archiveYear") == false).SelectMany(x => x.Children).Where(x => x.GetPropertyValue<bool>("bookingConfirmed")).ToList();

            List<string> bookingModel = new List<string>();

            foreach (var booking in bookingDetails)
            {
                var bookingDatesArrive = booking.GetPropertyValue<DateTime>("startDate");
                var bookingDatesDepart = booking.GetPropertyValue<DateTime>("endDate");

                for (var dt = bookingDatesArrive; dt <= bookingDatesDepart; dt = dt.AddDays(1))
                {
                    bookingModel.Add(dt.ToString("yyyy-MM-dd"));
                }
            }
            return Json(new { BookingArray = bookingModel.ToArray() }, JsonRequestBehavior.AllowGet);
        }
    }
}