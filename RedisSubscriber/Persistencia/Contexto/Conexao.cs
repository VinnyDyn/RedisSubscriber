using System;
using StackExchange.Redis;
using RedisSubscriber.Persistencia.Contexto.Interfaces;

namespace RedisSubscriber.Persistencia.Contexto
{
    public class Conexao : IConexao
    {
        public Conexao(IResolverConexao resolverConexao) => _resolverConexao = resolverConexao;

        private readonly IResolverConexao _resolverConexao;

        private IConnectionMultiplexer _sessao;
        public IConnectionMultiplexer Sessao
        {
            get { return _sessao ?? Abrir(); }
            private set { _sessao = value; }
        }

        public IConnectionMultiplexer Abrir()
        {
            return Equals(_sessao, null)
                ? ConnectionMultiplexer.Connect(_resolverConexao.ObterConnectionString())
                : _sessao;
        }

        public void Fechar()
        {
            if (!Equals(_sessao, null) || _sessao.IsConnected)
            {
                _sessao.Close();
                _sessao.Dispose();
            }
        }

        public bool HaConexao() => !Equals(_sessao, null) && _sessao.IsConnected;

        public void Dispose()
        {
            Fechar();
            GC.SuppressFinalize(this);
        }
    }
}
