using System.Globalization;

namespace CW11.DataAccessLayer.Extensions
{
    public static class DateTimeExtensions
    {
        static PersianCalendar persianCalendar = new PersianCalendar();

        public static string ToPersianDateTime(this DateTime dateTime)
        {
            return $"Date: {persianCalendar.GetYear(dateTime)} / {persianCalendar.GetMonth(dateTime)} / {persianCalendar.GetDayOfMonth(dateTime)} " +
                   $"| Time: {persianCalendar.GetHour(dateTime)} : {persianCalendar.GetMinute(dateTime)}";
        }
    }
}
