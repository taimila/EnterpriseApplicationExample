using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CrossCuttingConcerns.Logging;

namespace CrossCuttingConcerns.DependencyInjection
{
    public class CrossCuttingConcerns : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ExceptionLogger>());
        }
    }
}
