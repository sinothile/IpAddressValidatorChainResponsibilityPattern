namespace IpAddressValidatorKata
{
    public interface IValidator
    {
        void SetSuccessor(IValidator validator);
        bool Validate(string ipAddress);
    }
}
