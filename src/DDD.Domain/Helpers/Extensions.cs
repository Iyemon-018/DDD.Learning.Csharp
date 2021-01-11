namespace DDD.Domain.Helpers
{
    using System;

    public static class Extensions
    {
        public static float ToSingle(this double self)
        {
            return Convert.ToSingle(self);
        }
    }
}