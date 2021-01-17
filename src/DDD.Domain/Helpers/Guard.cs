namespace DDD.Domain.Helpers
{
    using Exceptions;

    /// <summary>
    /// 入力値のチェック関連をまとめたクラスです。
    /// <c>null</c> チェックなどのパターンが決まったエラーチェックについてはここで定義します。
    /// </summary>
    public static class Guard
    {
        public static void IsNullOrEmptyMessage(string value
                                              , string message)
        {
            IsNullOrEmptyMessage(value, message, ExceptionType.Information);
        }

        private static void IsNullOrEmptyMessage(string value
                                                , string message
                                                , ExceptionType exceptionType)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new MessageException(exceptionType, message);
            }
        }
    }
}