using System;

namespace LibraryManager.Util.Extensions
{
    public static class ExceptionExtensions
    {
        public static string GetExceptionMessage(this Exception ex)
        {
            if (ex.InnerException is null)
                return ex.Message;
            else
                return GetExceptionMessage(ex.InnerException);
        }
    }
}
