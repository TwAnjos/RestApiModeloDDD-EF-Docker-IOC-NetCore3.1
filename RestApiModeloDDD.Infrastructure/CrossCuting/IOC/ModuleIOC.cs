using Autofac;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            ConfigurationIOC.Load(containerBuilder);
        }
    }
}