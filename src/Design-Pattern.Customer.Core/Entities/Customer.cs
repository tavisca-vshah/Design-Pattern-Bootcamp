using Design_Pattern.Customer.Common;
using Design_Pattern.Customer.Core.ValidationStrategies;

namespace Design_Pattern.Customer.Core
{

    public class Customer : CustomerBase
    {
        private readonly IValidationStrategy<Customer> _validationStrategy;
        public Customer(IValidationStrategy<Customer> validationStrategy)
        {
            _validationStrategy = validationStrategy;
        }

        public override void Validate()
        {
            _validationStrategy?.Validate(this);
        }
    }
}
