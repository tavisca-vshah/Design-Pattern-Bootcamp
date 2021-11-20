using Design_Pattern.Customer.Common;

namespace Design_Pattern.Customer.Core.ValidationStrategies
{

    public class CustomerValidationStrategy : IValidationStrategy<Customer>
    {
        public void Validate(Customer obj)
        {
            Guard.Against.NullorEmpty(obj.CustomerName, nameof(Customer.CustomerName));
            Guard.Against.NullorEmpty(obj.PhoneNumber, nameof(Customer.PhoneNumber));
            Guard.Against.Null(obj.BillAmount, nameof(Customer.BillAmount));
            Guard.Against.Null(obj.BillDate, nameof(Customer.BillDate));
            Guard.Against.NullorEmpty(obj.Address, nameof(Customer.Address));
        }
    }
}
