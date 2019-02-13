using RedisSubscriber.Modelos.MensagemMds;
using RedisSubscriber.Interfaces.Repositorio;
using RedisSubscriber.Persistencia.Contexto.Interfaces;

namespace RedisSubscriber.Persistencia.Repositorio
{
    public class MensagemRep : IMensagemRep
    {
        public MensagemRep(IConexaoOuvinte conexao) => this._conexao = conexao;

        private IConexaoOuvinte _conexao;

        public string Receber(ReceberMd comando)
        {
            string resultado = null;
            this._conexao.Inscrito.Subscribe(comando.Canal, (canal, mensagem) =>
            {
                resultado = mensagem;
            });

            return resultado;
        }
    }
}
