namespace Design_Pattern.Customer.Core.ValidationStrategies
{
    public interface IValidationStrategy<T>
    {
        public void Validate(T obj);
    }
}
