using IpAddressValidatorKata2;
using NUnit.Framework;

namespace IpAddressValidatorKata2Tests
{
    [TestFixture]
    public class IpValidatorTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void WhenIpAddressIsNullOrEmptyOrWhiteSpace_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpace();
            var broadCastNetwork = new BroadCastNetwork();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidIpAddress = new InvalidIPAddress();

            nullOrWhiteSpace.Successor(broadCastNetwork);
            broadCastNetwork.Successor(entireNetworkSegment);
            entireNetworkSegment.Successor(invalidIpAddress);

            //Act
            var actual = nullOrWhiteSpace.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198")]   
        [TestCase("192.56")]
        [TestCase("176.8.2")]
        public void WhenIpAddressHaveLessThanFourOctets_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpace();
            var broadCastNetwork = new BroadCastNetwork();  
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidIpAddress = new InvalidIPAddress();

            nullOrWhiteSpace.Successor(broadCastNetwork);   
            broadCastNetwork.Successor(entireNetworkSegment);
            entireNetworkSegment.Successor(invalidIpAddress);

            //Act
            var actual = nullOrWhiteSpace.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198.3.4.5")]
        [TestCase("192.56.1.1")]
        [TestCase("176.8.2.9")]
        public void WhenIpAddressHaveFourOctets_ShouldReturnTrue(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpace();
            var broadCastNetwork = new BroadCastNetwork();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidIpAddress = new InvalidIPAddress();

            nullOrWhiteSpace.Successor(broadCastNetwork);
            broadCastNetwork.Successor(entireNetworkSegment);
            entireNetworkSegment.Successor(invalidIpAddress);

            //Act
            var actual = nullOrWhiteSpace.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.True);
        }

        [TestCase("198.4.5.0")]
        [TestCase("0.0.0.0")]
        public void WhenIpAddressRepresentsEntireNetworkSegment_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpace();
            var broadCastNetwork = new BroadCastNetwork();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidIpAddress = new InvalidIPAddress();  

            nullOrWhiteSpace.Successor(broadCastNetwork);
            broadCastNetwork.Successor(entireNetworkSegment);
            entireNetworkSegment.Successor(invalidIpAddress);

            //Act
            var actual = nullOrWhiteSpace.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198.4.5.255")]
        [TestCase("0.0.0.255")]
        public void WhenIpAddressRepresentsBroadCastNetwork_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var nullOrWhiteSpace = new NullOrWhiteSpace();
            var broadCastNetwork = new BroadCastNetwork();
            var entireNetworkSegment = new EntireNetworkSegment();
            var invalidIpAddress = new InvalidIPAddress();

            nullOrWhiteSpace.Successor(broadCastNetwork);
            broadCastNetwork.Successor(entireNetworkSegment);
            entireNetworkSegment.Successor(invalidIpAddress);

            //Act
            var actual = nullOrWhiteSpace.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }
    }
}
