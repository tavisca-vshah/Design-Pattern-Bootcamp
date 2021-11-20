using Design_Pattern.Customer.Common;

namespace Design_Pattern.Customer.Core.ValidationStrategies
{
    public class LeadCustomerValidationStrategy : IValidationStrategy<LeadCustomer>
    {
        public void Validate(LeadCustomer obj)
        {
            Guard.Against.NullorEmpty(obj.CustomerName, nameof(Customer.CustomerName));
            Guard.Against.NullorEmpty(obj.PhoneNumber, nameof(Customer.PhoneNumber));
        }
    }
}
