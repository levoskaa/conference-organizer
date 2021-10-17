using Autofac;
using System.Linq;
using System.Reflection;

namespace BLL
{
    public class BllModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var assembly = Assembly.GetAssembly(typeof(BllModule));
            builder.RegisterAssemblyTypes(assembly)
                .Where(type => type.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}