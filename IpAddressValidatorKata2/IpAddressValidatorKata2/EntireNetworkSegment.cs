using System.Linq;

namespace IpAddressValidatorKata2
{
    public class EntireNetworkSegment : IIpAddressValidator
    {
        private IIpAddressValidator _validator;
        public void Successor(IIpAddressValidator validator)
        {
            _validator = validator;
        }

        public bool ValidateIpAddress(string ipAddress)
        {
            var ipAddressStorage = ipAddress.Split('.');

            if (IpAddressTargetsEntireNetworkSegment(ipAddressStorage))
            {
                return false;
            }

            return _validator.ValidateIpAddress(ipAddress);
        }

        private bool IpAddressTargetsEntireNetworkSegment(string[] ipAddressStorage)
        {
            return ipAddressStorage.Last() == "0";
        }
    }
}
