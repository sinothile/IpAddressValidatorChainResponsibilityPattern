namespace IpAddressValidatorKata2
{
    public class InvalidIPAddress : IIpAddressValidator
    {
        private IIpAddressValidator _validator;
        public void Successor(IIpAddressValidator validator)
        {
            _validator = validator;
        }

        public bool ValidateIpAddress(string ipAddress)
        {
            var ipAddressStorage = ipAddress.Split('.');
            if (IpAddressHasLessOrMoreThanFourOctets(ipAddressStorage))
            {
                return false;
            }

            return true;
        }

        private bool IpAddressHasLessOrMoreThanFourOctets(string[] ipAddressStorage)
        {
            return ipAddressStorage.Length != 4;
        }
    }
}
