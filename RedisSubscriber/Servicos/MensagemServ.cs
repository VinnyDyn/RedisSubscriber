using RedisSubscriber.Interfaces.Servico;
using RedisSubscriber.Modelos.MensagemMds;
using RedisSubscriber.Interfaces.Repositorio;

namespace RedisSubscriber.Servicos
{
    public class MensagemServ : IMensagemServ
    {
        public MensagemServ(IMensagemRep rep) => this._rep = rep;

        private readonly IMensagemRep _rep;

        public string Receber(ReceberMd comando) => this.Receber(comando);
    }
}
