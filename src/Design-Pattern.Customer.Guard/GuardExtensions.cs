namespace Design_Pattern.Customer.Common
{
    public static class GuardExtensions
    {
        public static void Null<T>(this IGuardClause guardClause, T obj,string parameter, string msg = null)
        {
            if(obj == null)
            {
                throw new InvalidOperationException(msg ?? $"{parameter} can not be null");
            }
        }
        public static void NullorEmpty(this IGuardClause guardClause, string obj, string parameter, string msg = null)
        {
            if (obj == null)
            {
                throw new InvalidOperationException(msg ?? $"{parameter} can not be null or empty");
            }
        }
        public static void DefaultValue<T>(this IGuardClause guardClause, T obj, string parameter, string msg = null) where T: struct
        {
            if (obj.Equals(default(T)))
            {
                throw new InvalidOperationException(msg ?? $"The value {default(T)} for {parameter} provided in request not allowed");
            }
        }
    }
}
