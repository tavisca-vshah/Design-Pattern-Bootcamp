using Design_Pattern.Customer.Common;
using Design_Pattern.Customer.Core.ValidationStrategies;
using System;

namespace Design_Pattern.Customer.Core
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public decimal? BillAmount { get; set; }
        public DateTime? BillDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual void Validate()
        {
            throw new NotImplementedException("Not implemented");
        }
    }
}
