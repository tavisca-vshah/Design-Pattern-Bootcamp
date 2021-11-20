using Design_Pattern.Customer.Core.ValidationStrategies;
using Microsoft.Extensions.DependencyInjection;

namespace Design_Pattern.Customer.Core
{
    public static class ServiceModule
    {
        public static void InitializeCoreDependency(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IValidationStrategy<Customer>, CustomerValidationStrategy>();
            serviceCollection.AddSingleton<IValidationStrategy<LeadCustomer>, LeadCustomerValidationStrategy>();
            serviceCollection.AddSingleton<Customer>();
            serviceCollection.AddSingleton<LeadCustomer>();
        }
    }
}
