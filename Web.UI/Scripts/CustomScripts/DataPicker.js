$(document).ready(function () {
    //Custom script for datepicker
    var array;
    $.getJSON("/Umbraco/Surface/Booking/GetCurrentBookings", function (data) {
        array = data.BookingArray;

        $("#from").datepicker({
            defaultDate: "+1w",
            changeMonth: true,
            numberOfMonths: 3,
            minDate: 0,
            beforeShowDay: function (date) {
                var string = jQuery.datepicker.formatDate("yy-mm-dd", date);
                return [array.indexOf(string) === -1];
            }
        }).on("change", function () {
            to.datepicker("option", "minDate", getDate(this));
        }),
            $("#to").datepicker({
                defaultDate: "+1w",
                changeMonth: true,
                numberOfMonths: 3,
                minDate: 0,
                beforeShowDay: function (date) {
                    var string = jQuery.datepicker.formatDate("yy-mm-dd", date);
                    return [array.indexOf(string) === -1];
                }
            })
                .on("change", function () {
                    from.datepicker("option", "maxDate", getDate(this));
                });
    });
});