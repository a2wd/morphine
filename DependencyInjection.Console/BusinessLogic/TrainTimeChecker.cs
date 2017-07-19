namespace DependencyInjection.Console
{
    public class TrainTimeChecker
    {
        private readonly ISoapClient _soapClient;
        private readonly ICredentialAgent _credentialAgent;
        private readonly IInputParser _inputParser;

        public TrainTimeChecker(ISoapClient soapClient, ICredentialAgent credentialAgent, IInputParser inputParser)
        {
            _soapClient = soapClient;
            _credentialAgent = credentialAgent;
            _inputParser = inputParser;
        }
    }
}
