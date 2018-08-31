using System.Linq;

namespace IpAddressValidatorKata
{
    public class BroadCastAddress : IValidator
    {
        private IValidator _validator;
        public void SetSuccessor(IValidator validator)
        {
            _validator = validator;
        }

        public bool Validate(string ipAddress)
        {
            var octects = ipAddress.Split('.');
            if (LastOctectIsEquals255(octects))
            {
                return false;
            }
            return _validator.Validate(ipAddress);
        }

        private bool LastOctectIsEquals255(string[] octects)
        {
            return octects.Last() == "255";
        }
    }
}
