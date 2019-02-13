using System.Configuration;
using RedisSubscriber.Persistencia.Contexto.Interfaces;

namespace RedisSubscriber.Auxiliares
{
    public class ResolverConexao : IResolverConexao
    {
        public string ObterConnectionString() => ConfigurationManager.ConnectionStrings["BancoRedis"].ConnectionString;
    }
}
