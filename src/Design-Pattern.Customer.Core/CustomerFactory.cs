using System;
using System.Collections.Concurrent;

namespace Design_Pattern.Customer.Core
{
    public static class CustomerFactory
    {
        //Factory Design Pattern: Taking responsibility of creating object in centralized location
        private static IServiceProvider _serviceProvider;
        private static readonly ConcurrentDictionary<string, CustomerBase> customerMapping = new(StringComparer.OrdinalIgnoreCase);
        public static void Initialize(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            //if (customerMapping.IsEmpty)
            //{
            //    //Eager Loading
            //    customerMapping.TryAdd("customer", (Customer)_serviceProvider.GetService(typeof(Customer)));
            //    customerMapping.TryAdd("lead", (LeadCustomer)_serviceProvider.GetService(typeof(LeadCustomer)));
            //}
        }
        public static CustomerBase Create(string type)
        {
            if(customerMapping.IsEmpty)
            {
                //Lazy Loading: Load object on demand with RIP Replace IF with Polymorphism
                customerMapping.TryAdd("customer", (Customer)_serviceProvider.GetService(typeof(Customer)));
                customerMapping.TryAdd("lead", (LeadCustomer)_serviceProvider.GetService(typeof(LeadCustomer)));
            }

            if(customerMapping.TryGetValue(type, out CustomerBase entity))
            {
                return entity;
            }
            throw new ArgumentException("Invalid customer type provided in request");
        }
    }
}