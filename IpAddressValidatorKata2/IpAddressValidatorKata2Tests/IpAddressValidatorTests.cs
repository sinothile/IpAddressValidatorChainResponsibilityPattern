using IpAddressValidatorKata2;
using NUnit.Framework;

namespace IpAddressValidatorKata2Tests
{
    [TestFixture]
    public class IpAddressValidatorTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ValidateIpAddress_GivenIpAddressWithEmptyOrNullOrWhiteSpace_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var sut = new IpAddressValidator();

            //Act
            var actual = sut.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198.3.4.5")]
        [TestCase("192.56.1.1")]
        [TestCase("176.8.2.9")]
        public void ValidateIpAddress_GivenIpAddressWithFourOctets_ShouldReturnTrue(string ipAddress)
        {
            //Arrange
            var sut = new IpAddressValidator(); 

            //Act   
            var actual = sut.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.True);
        }

        [TestCase("198")]
        [TestCase("192.56")]
        [TestCase("176.8.2")]
        public void ValidateIpAddress_GivenIpAddressWithLessThanFourOctets_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var sut = new IpAddressValidator();

            //Act
            var actual = sut.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198.1.1.1.1")]
        [TestCase("192.56.3.4.5")]
        [TestCase("176.8.2.1.1")]
        public void ValidateIpAddress_GivenIpAddressWithMoreThanFourOctets_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var sut = new IpAddressValidator();

            //Act
            var actual = sut.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198.4.5.0")]
        [TestCase("0.0.0.0")]
        public void ValidateIpAddress_GivenIpAddressRepresentingEntireNetworkSegment_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var sut = new IpAddressValidator();
                
            //Act
            var actual = sut.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

        [TestCase("198.4.5.255")]
        [TestCase("0.0.0.255")]
        public void ValidateIpAddress_GivenIpAddressRepresentingBroadCastNetwork_ShouldReturnFalse(string ipAddress)
        {
            //Arrange
            var sut = new IpAddressValidator();

            //Act
            var actual = sut.ValidateIpAddress(ipAddress);

            //Assert
            Assert.That(actual, Is.False);
        }

    }
}
