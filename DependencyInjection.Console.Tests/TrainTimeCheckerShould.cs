namespace DependencyInjection.Console.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class TrainTimeCheckerShould
    {
        [TestMethod]
        public void InstantiateCorrectlyWithMocks()
        {
            var mockSoapClient = new Mock<ISoapClient>();
            var mockCredentialAgent = new Mock<ICredentialAgent>();
            var mockInputParser = new Mock<IInputParser>();

            TrainTimeChecker trainTimeChecker = new TrainTimeChecker(
                mockSoapClient.Object,
                mockCredentialAgent.Object,
                mockInputParser.Object);

            Assert.IsNotNull(trainTimeChecker);
        }
    }
}
