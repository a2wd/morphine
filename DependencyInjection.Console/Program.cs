namespace DependencyInjection.Console
{
    using Castle.MicroKernel.Registration;
    using Castle.Windsor;
    using DependencyInjection.Console.Implementations;

    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(
                Component.For<ISoapClient>().ImplementedBy<SoapClient>(),
                Component.For<ICredentialAgent>().ImplementedBy<SimpleCredentialAgent>(),
                Component.For<IInputParser>().ImplementedBy<ConsoleInputParser>(),
                Component.For<TrainTimeChecker>()
            );

            TrainTimeChecker trainTimeChecker = container.Resolve<TrainTimeChecker>();
        }
    }
}