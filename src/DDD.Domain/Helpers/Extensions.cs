namespace DDD.Domain.Helpers
{
    using System;

    public static class Extensions
    {
        public static float ToSingle(this double self)
        {
            return Convert.ToSingle(self);
        }

        public static DateTime ToDate(this string self)
        {
            return DateTime.ParseExact(self, "yyyy/MM/dd HH:mm:ss", null);
        }
    }
}