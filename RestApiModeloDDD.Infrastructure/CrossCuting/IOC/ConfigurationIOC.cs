using Autofac;
using RestApiModeloDDD.Application;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Services;
using RestApiModeloDDD.Infrastructure.CrossCuting.Mapper;
using RestApiModeloDDD.Infrastructure.Data.Repositorys;

namespace RestApiModeloDDD.Infrastructure.CrossCuting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            #region IOC

            containerBuilder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            containerBuilder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            containerBuilder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            containerBuilder.RegisterType<ServiceProduto>().As<IServiceProduto>();

            containerBuilder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            containerBuilder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();

            containerBuilder.RegisterType<MapperCliente>().As<IMapperCliente>();
            containerBuilder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}