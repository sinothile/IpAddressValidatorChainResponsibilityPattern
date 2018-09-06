namespace IpAddressValidatorKata2
{
    public class NullOrWhiteSpace : IIpAddressValidator
    {
        private IIpAddressValidator _validator;
        public void Successor(IIpAddressValidator validator)
        {
            _validator = validator;
        }

        public bool ValidateIpAddress(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                return false;
            }

            return _validator.ValidateIpAddress(ipAddress);
        }
    }
}
