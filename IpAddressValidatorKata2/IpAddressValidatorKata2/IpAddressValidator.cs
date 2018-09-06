using System.Linq;

namespace IpAddressValidatorKata2
{
    public class IpAddressValidator
    {
        public bool ValidateIpAddress(string ipAddress)
        {
            if (NullOrWhiteSpace(ipAddress))
            {
                return false;
            }

            var ipAddressStorage = ipAddress.Split('.');

            if (IpAddressHaveLessOrMoreThanFourOctets(ipAddressStorage))
            {
                return false;
            }

            if (IpAddressTargetsEntireNetworkSegment(ipAddressStorage))
            {
                return false;
            }

            if (IpAddressTargetsBroadCastNetwork(ipAddressStorage))
            {
                return false;
            }

            return true;
        }

        private bool IpAddressTargetsBroadCastNetwork(string[] ipAddressStorage)
        {
            return ipAddressStorage.Last() == "255";
        }

        private bool IpAddressTargetsEntireNetworkSegment(string[] ipAddressStorage)
        {
            return ipAddressStorage.Last() == "0";
        }

        private bool IpAddressHaveLessOrMoreThanFourOctets(string[] ipAddressStorage)
        {
            return ipAddressStorage.Length != 4;
        }

        private bool NullOrWhiteSpace(string ipAddress)
        {
            return string.IsNullOrWhiteSpace(ipAddress);
        }
    }
}
    