using Castle.Facilities.Logging;
using Castle.Windsor;

namespace CrossCuttingConcerns.DependencyInjection
{
    public class CompositionRoot
    {
        public virtual void ComposeApplication(IWindsorContainer container)
        {
            container.AddFacility<LoggingFacility>(f => f.UseLog4Net());

            container.Install(
                new CrossCuttingConcerns(),
                new Persistence(),
                new Domain(),
                new Business()
            );
        }
    }
}
