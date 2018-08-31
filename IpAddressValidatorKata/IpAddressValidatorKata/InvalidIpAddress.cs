namespace IpAddressValidatorKata
{
    public class InvalidIpAddress : IValidator
    {
        private IValidator _validator;
        public void SetSuccessor(IValidator validator)
        {
            _validator = validator;
        }

        public bool Validate(string ipAddress)
        {
            var octects = ipAddress.Split('.');
            if (IpAdressIsInvalid(octects))
            {
                return false;
            }

            return true;
        }

        private bool IpAdressIsInvalid(string[] octects)
        {
            return octects.Length != 4;
        }
    }
}
