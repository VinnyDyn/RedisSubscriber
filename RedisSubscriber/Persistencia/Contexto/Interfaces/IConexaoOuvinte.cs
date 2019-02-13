using StackExchange.Redis;

namespace RedisSubscriber.Persistencia.Contexto.Interfaces
{
    public interface IConexaoOuvinte : IConexao
    {
        ISubscriber Inscrito { get; }
    }
}
