using Business.Commands.ChangeInvoiceDuedate;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CrossCuttingConcerns.Logging;

namespace CrossCuttingConcerns.DependencyInjection
{
    public class Business : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Classes.FromAssemblyContaining<ChangeInvoiceDuedateCommand>()
                                      .Where(type => type.Name.EndsWith("Query"))
                                      .WithServiceSelf()
                                      .Configure(c => c.LifestyleSingleton().Interceptors<ExceptionLogger>()));

            container.Register(Classes.FromAssemblyContaining<ChangeInvoiceDuedateCommand>()
                                      .Where(type => type.Name.EndsWith("Command"))
                                      .WithServiceSelf()
                                      .Configure(c => c.LifestyleSingleton().Interceptors<ExceptionLogger>()));
        }
    }
}