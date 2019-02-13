using System;
using SimpleInjector;
using RedisSubscriber.Servicos;
using SimpleInjector.Lifestyles;
using RedisSubscriber.Aplicacao;
using RedisSubscriber.Auxiliares;
using RedisSubscriber.Interfaces.Servico;
using RedisSubscriber.Interfaces.Aplicacao;
using RedisSubscriber.Persistencia.Contexto;
using RedisSubscriber.Interfaces.Repositorio;
using RedisSubscriber.Persistencia.Repositorio;
using RedisSubscriber.Persistencia.Contexto.Interfaces;

namespace RedisSubscriber
{
    public class InjecaoDeDependencia : IDisposable
    {
        private static Container _container = null;
        private Container Container
        {
            get
            {
                if (Equals(_container, null))
                {
                    Lifestyle lifeStyle = Lifestyle.Singleton;
                    _container = new Container();
                    _container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();
                    Registrar(_container, lifeStyle);
                }

                return _container;
            }
        }

        private static void Registrar(Container container, Lifestyle lifeStyle)
        {
            container.Register<IOuvinteApp, OuvinteApp>();
            container.Register<IOuvinteServ, OuvinteServ>();
            container.Register<IOuvinteRep, OuvinteRep>();
            container.Register<IResolverConexao, ResolverConexao>();
            container.Register<IConexaoOuvinte, ConexaoOuvinte>();
        }

        public Tipo Invocar<Tipo>() where Tipo : class => Container.GetInstance<Tipo>();

        public void Dispose() { }
    }
}
