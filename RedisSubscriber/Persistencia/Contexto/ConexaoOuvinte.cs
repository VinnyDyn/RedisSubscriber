using StackExchange.Redis;
using RedisSubscriber.Persistencia.Contexto.Interfaces;

namespace RedisSubscriber.Persistencia.Contexto
{
    public class ConexaoOuvinte : Conexao, IConexaoOuvinte
    {
        public ConexaoOuvinte(IResolverConexao resolverConexao)
            : base(resolverConexao) { }

        public ISubscriber Inscrito => !Equals(Sessao, null) ? Sessao.GetSubscriber() : Abrir().GetSubscriber();
    }
}
