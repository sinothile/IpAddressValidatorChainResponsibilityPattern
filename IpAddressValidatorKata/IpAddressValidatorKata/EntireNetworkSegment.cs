using System.Linq;

namespace IpAddressValidatorKata
{
    public class EntireNetworkSegment : IValidator
    {
        private IValidator _validator;
        public void SetSuccessor(IValidator validator)
        {
            _validator = validator;
        }

        public bool Validate(string ipAddress)
        {
            var octects = ipAddress.Split('.');
            if (LastOctectIsEquals0(octects))
            {
                return false;
            }
            return _validator.Validate(ipAddress);
        }

        private bool LastOctectIsEquals0(string[] octects)
        {
            return octects.Last() == "0";
        }
    }
}
