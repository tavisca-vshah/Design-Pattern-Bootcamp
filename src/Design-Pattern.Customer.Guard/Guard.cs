using System;

namespace Design_Pattern.Customer.Common
{
    public interface IGuardClause
    {
    }

    public class Guard : IGuardClause
    {
        public static readonly IGuardClause Against = new Guard();
    }
}
