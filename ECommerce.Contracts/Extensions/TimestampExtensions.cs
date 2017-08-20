using System;

namespace ECommerce.Contracts.Extensions
{
    public static class TimestampExtensions
    {
        private static DateTime NineteenSeventy = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static DateTime ToDateTime(this Timestamp timestamp)
        {
            return NineteenSeventy + TimeSpan.FromSeconds(timestamp.Epoch);
        }
    }
}
