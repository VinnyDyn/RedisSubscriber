using RedisSubscriber.Modelos.MensagemMds;

namespace RedisSubscriber.Interfaces.Repositorio
{
    public interface IMensagemRep
    {
        string Receber(ReceberMd comando);
    }
}
