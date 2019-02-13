using RedisSubscriber.Modelos.MensagemMds;

namespace RedisSubscriber.Interfaces.Servico
{
    public interface IMensagemServ
    {
        string Receber(ReceberMd comando);
    }
}
