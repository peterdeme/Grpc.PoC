using System;

namespace ECommerce.Contracts.Extensions
{
    public static class DateTimeExtensions
    {
        public static Timestamp ToTimeStamp(this DateTime date)
        {
            return new Timestamp
            {
                Epoch = new DateTimeOffset(date).ToUnixTimeSeconds()
            };
        }
    }
}
