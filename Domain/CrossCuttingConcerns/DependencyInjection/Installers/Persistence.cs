using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MongoDB.Driver;
using Persistence;

namespace CrossCuttingConcerns.DependencyInjection
{
    public class Persistence : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            RegiterMongoDb(container);
            RegisterRepositories(container);
        }

        protected virtual void RegiterMongoDb(IWindsorContainer container)
        {
            var mongoClient = new MongoClient("mongodb://localhost");
            container.Register(Component.For<MongoClient>().Instance(mongoClient));
        }

        void RegisterRepositories(IWindsorContainer container)
        {
            container.Register(Classes.FromAssemblyContaining<MongoRepository>()
                                      .BasedOn<MongoRepository>()
                                      .WithServiceFirstInterface()
                                      .LifestyleSingleton());
        }
    }
}
