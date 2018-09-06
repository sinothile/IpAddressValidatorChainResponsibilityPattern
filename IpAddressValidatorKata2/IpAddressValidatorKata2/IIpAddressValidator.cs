
namespace IpAddressValidatorKata2
{
    public interface IIpAddressValidator
    {
         void Successor(IIpAddressValidator validator);
         bool ValidateIpAddress(string ipAddress);
    }
}
