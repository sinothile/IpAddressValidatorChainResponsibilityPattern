using System.Linq;

namespace IpAddressValidatorKata2
{
    public class BroadCastNetwork : IIpAddressValidator
    {
        private IIpAddressValidator _validator;
        public void Successor(IIpAddressValidator validator)
        {
            _validator = validator;
        }

        public bool ValidateIpAddress(string ipAddress)
        {
            var ipAddressStorage = ipAddress.Split('.');

            if (IpAddressTargetsBroadCastNetwork(ipAddressStorage))
            {
                return false;
            }

            return _validator.ValidateIpAddress(ipAddress);
        }

        private bool IpAddressTargetsBroadCastNetwork(string[] ipAddressStorage)
        {
            return ipAddressStorage.Last() == "255";
        }
    }
}
