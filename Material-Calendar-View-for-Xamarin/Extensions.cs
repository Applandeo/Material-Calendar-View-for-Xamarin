using System;
using Java.Util;

namespace MaterialCalendarView
{
    public static class Extensions
    {
        private readonly static DateTime ZeroTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ToDateTime(this Calendar calendar) => FromUnixTime(calendar.TimeInMillis);

        private static DateTime FromUnixTime(long unixTimeMillis) => ZeroTime.AddMilliseconds(unixTimeMillis);
    }
}
