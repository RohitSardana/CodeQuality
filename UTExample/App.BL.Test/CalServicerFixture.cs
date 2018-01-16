using NUnit.Framework;
using App.Service;
using Moq;

namespace App.BL.Test
{
    [TestFixture]
    public class CalServicerFixture
    {
        [Test]
        public void WhenAddingTwoNumbers()
        {
            //Arrange
            var mockCalBL = new Mock<ICalculatorBl>();
            int expectedResult = 42;
            mockCalBL.Setup(x => x.Add(It.IsAny<string>(), It.IsAny<string>())).Returns(expectedResult);

            //Act
            ICalService calService=new CalService(mockCalBL.Object);
            var result =  calService.Add("7", "8");

            //Assert
            Assert.IsTrue(result==expectedResult);
        }

        [Test]
        public void WhenSubtactingTwoNumbers()
        {
            //Arrange
            var mockCalBL = new Mock<ICalculatorBl>();
            int expectedResult = 42;
            mockCalBL.Setup(x => x.Subtract(It.IsAny<string>(), It.IsAny<string>())).Returns(expectedResult);

            //Act
            ICalService calService = new CalService(mockCalBL.Object);
            var result = calService.Subtract("7", "8");

            //Assert
            Assert.IsTrue(result == expectedResult);
        }
    }
}
