using Design_Pattern.Customer.Core.ValidationStrategies;

namespace Design_Pattern.Customer.Core
{
    public class LeadCustomer : CustomerBase
    {
        private readonly IValidationStrategy<LeadCustomer> _validationStrategy;
        public LeadCustomer(IValidationStrategy<LeadCustomer> validationStrategy)
        {
            _validationStrategy = validationStrategy;
        }
        public override void Validate()
        {
            _validationStrategy?.Validate(this);
        }
    }
}
