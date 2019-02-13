using RedisSubscriber.Interfaces.Servico;
using RedisSubscriber.Modelos.MensagemMds;
using RedisSubscriber.Interfaces.Aplicacao;

namespace RedisSubscriber.Aplicacao
{
    public class MensagemApp : IMensagemApp
    {
        public MensagemApp(IMensagemServ serv) => this._serv = serv;

        private readonly IMensagemServ _serv;

        public string Receber(ReceberMd comando) => this._serv.Receber(comando);
    }
}
