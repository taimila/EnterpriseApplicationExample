using Castle.Facilities.WcfIntegration;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CrossCuttingConcerns.DependencyInjection;
using System;

namespace Services
{
    public class Global : System.Web.HttpApplication
    {
        WindsorContainer container;

        protected void Application_Start(object sender, EventArgs e)
        {
            container = new WindsorContainer();
            container.AddFacility<WcfFacility>();

            container.Register(Classes.FromThisAssembly()
                                      .Where(type => type.Name.EndsWith("Service"))
                                      .WithServiceDefaultInterfaces()
                                      .Configure(component => component.Named(component.Implementation.FullName)));

            new CompositionRoot().ComposeApplication(container);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (container != null)
                container.Dispose();
        }
    }
}