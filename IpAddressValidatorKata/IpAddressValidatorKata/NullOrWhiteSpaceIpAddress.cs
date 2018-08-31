namespace IpAddressValidatorKata
{
    public class NullOrWhiteSpaceIpAddress : IValidator
    {
        private IValidator _validator;
        public void SetSuccessor(IValidator validator)
        {
            _validator = validator;
        }

        public bool Validate(string ipAddress)
        {
            if (NullOrWhiteSpace(ipAddress))
            {
                return false;
            }
            return _validator.Validate(ipAddress);
        }

        private bool NullOrWhiteSpace(string ipAddress)
        {
            return string.IsNullOrWhiteSpace(ipAddress);
        }
    }
}
