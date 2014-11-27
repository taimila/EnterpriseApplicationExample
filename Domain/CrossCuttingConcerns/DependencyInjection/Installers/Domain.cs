using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using EnterpriseApplication.Invoice;

namespace CrossCuttingConcerns.DependencyInjection
{
    public class Domain : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyContaining<InvoiceFactory>()
                                      .Where(type => type.Name.EndsWith("Factory"))
                                      .WithServiceSelf()
                                      .LifestyleSingleton());
        }
    }
}
