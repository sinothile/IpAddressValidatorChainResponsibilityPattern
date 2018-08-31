using IpAddressValidatorKata;
using NUnit.Framework;

namespace IpAddressValidatorTests
{
    [TestFixture]
    public class IpValidatorTests
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        public void WhenIpAddressIsNullOrWhiteSpace_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpaceIpAddress();
            var broadCastAddress = new BroadCastAddress();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidAddress = new InvalidIpAddress();

            nullOrWhiteSpace.SetSuccessor(broadCastAddress);
            broadCastAddress.SetSuccessor(entireNetworkSegment);
            entireNetworkSegment.SetSuccessor(invalidAddress);

            //Act
            var actual = nullOrWhiteSpace.Validate(ipAddress);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestCase("96.7.8.6")]
        [TestCase("198.7.4.6")]
        [TestCase("172.3.8.4")]
        public void WhenIpAddressHas4Octects_ShouldReturnTrue(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpaceIpAddress();
            var broadCastAddress = new BroadCastAddress();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidAddress = new InvalidIpAddress();

            nullOrWhiteSpace.SetSuccessor(broadCastAddress);
            broadCastAddress.SetSuccessor(entireNetworkSegment);
            entireNetworkSegment.SetSuccessor(invalidAddress);

            //Act
            var actual = nullOrWhiteSpace.Validate(ipAddress);

            //Assert
            Assert.IsTrue(actual);
        }

        [TestCase("1")]
        [TestCase("79.6")]
        [TestCase("96.7.8")]
        public void WhenIpAddressHasLessThan4Octects_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpaceIpAddress();
            var broadCastAddress = new BroadCastAddress();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidAddress = new InvalidIpAddress();

            nullOrWhiteSpace.SetSuccessor(broadCastAddress);
            broadCastAddress.SetSuccessor(entireNetworkSegment);
            entireNetworkSegment.SetSuccessor(invalidAddress);

            //Act
            var actual = nullOrWhiteSpace.Validate(ipAddress);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestCase("172.13.8.4.5")]
        [TestCase("172.13.8.4.5.4.7")]
        [TestCase("172.13.8.4.5.4.6.9")]
        public void WhenIpAddressHasMoreThan4Octects_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpaceIpAddress();
            var broadCastAddress = new BroadCastAddress();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidAddress = new InvalidIpAddress();

            nullOrWhiteSpace.SetSuccessor(broadCastAddress);
            broadCastAddress.SetSuccessor(entireNetworkSegment);
            entireNetworkSegment.SetSuccessor(invalidAddress);

            //Act
            var actual = nullOrWhiteSpace.Validate(ipAddress);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestCase("172.13.6.0")]
        [TestCase("0.0.0.0")]
        [TestCase("192.5.4.0")]
        public void WhenLastOctectOfIpAddressIs0_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpaceIpAddress();
            var broadCastAddress = new BroadCastAddress();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidAddress = new InvalidIpAddress();

            nullOrWhiteSpace.SetSuccessor(broadCastAddress);
            broadCastAddress.SetSuccessor(entireNetworkSegment);
            entireNetworkSegment.SetSuccessor(invalidAddress);

            //Act
            var actual = nullOrWhiteSpace.Validate(ipAddress);

            //Assert
            Assert.IsFalse(actual);
        }

        [TestCase("192.5.6.255")]
        [TestCase("172.2.4.255")]
        [TestCase("198.5.3.255")]
        public void WhenLastOctectOfIpAddressIs255_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpaceIpAddress();
            var broadCastAddress = new BroadCastAddress();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidAddress = new InvalidIpAddress();

            nullOrWhiteSpace.SetSuccessor(broadCastAddress);
            broadCastAddress.SetSuccessor(entireNetworkSegment);
            entireNetworkSegment.SetSuccessor(invalidAddress);

            //Act
            var actual = nullOrWhiteSpace.Validate(ipAddress);

            //Assert
            Assert.IsFalse(actual);
        }
    }
}
